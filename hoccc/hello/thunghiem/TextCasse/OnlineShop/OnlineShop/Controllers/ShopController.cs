using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop.Models.Cart;
using OnlineShop.Services;
using OnlineShop.Services.Cartservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;

        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "PNBS";

        public ShopController(ICategoryService categoryService, IProductService productService)
        {
            this.categoryService = categoryService;
            this.productService = productService;
        }
        public async Task<IActionResult> Index(int status)
        {
            return View(await categoryService.GetCategories());
        }


        /// Thêm sản phẩm vào cart
        [Route("/Shop/AddToCart/{productId:int}", Name = "Index")]
        public async Task<IActionResult> AddToCart(int productId)
        {
            if (UserController.Check == true)
            {
                var product = await productService.GetProductById(productId);
                if (product == null)
                    return NotFound("Không có sản phẩm");

                var productItem = new ProductItem()
                {
                    ProductId = product.ID,
                    Quantity = product.Quantity,
                    ProdcutName = product.Product_Name,
                    Priceproduct = product.Price,
                    Promotion_Price = product.Promotion_Price,
                    Photo = product.Image,
                    Metatitle = product.Metatitle,
                    CategoryId = product.Category_ID,

                };
                // Xử lý đưa vào Cart ...

                var cart = GetCartItems();
                var cartitem = cart.Find(b => b.Product.ProductId == productId);
                if (cartitem != null)
                {
                    // Đã tồn tại, tăng thêm 1
                    cartitem.Quantity++;
                }
                else
                {
                    //  Thêm mới
                    cart.Add(new CartItem() { Quantity = 1, Product = productItem });
                }

                // Lưu cart vào Session
                SaveCartSession(cart);
                // Chuyển đến trang hiện thị Cart
                return RedirectToAction("Cart");
            }
            else
            {
                return Redirect("/User/Login");
            }    
        }
           

        // Hiện thị giỏ hàng
        [Route("Shop/Cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }

        [Route("Shop/UpdateCart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productId, [FromForm] int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.Product.ProductId == productId);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity = quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }

        /// xóa item trong cart
        [Route("/Shop/RemoveCart/{productId:int}")]
        public IActionResult RemoveCart([FromRoute] int productId)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.Product.ProductId == productId);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        // Lấy cart từ Session (danh sách CartItem)
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
    }
}
