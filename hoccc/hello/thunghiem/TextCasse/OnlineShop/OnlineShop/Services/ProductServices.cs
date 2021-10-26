using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DbContexts;
using OnlineShop.Entities;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static OnlineShop.Helper.Helper;
namespace OnlineShop.Services
{
    public class ProductServices
    {
        private OnlineShopDbContext _context;
        public ProductServices(OnlineShopDbContext context)
        {
            _context = context;
        }
        // Lấy danh sách sản phẩm
        public async Task<PagingResult<Product>> GetProcducts(int page = 1, int pageSize = 10)
        {
            var model = _context.Products.Where(x => x.Status == true).OrderByDescending(x => x.ID);
            var resutl = await PagingResult<Product>.CreateAsync(model.AsNoTracking(), page, pageSize);
            return resutl;
        }
        //Tạo mới sản phẩm
        public bool CreateProduct(Product entity, IFormFile Image)
        {
            try
            {
                var pro = new Product();
                pro.Product_Name = entity.Product_Name;
                pro.Metatitle = Str_Metatitle(entity.Product_Name);
                pro.Promotion_Price = entity.Promotion_Price;
                pro.Price = entity.Price;
                pro.Category_ID = entity.Category_ID;
                pro.Quantity = entity.Quantity;
                pro.Status = true;
                //Thêm hình ảnh
                pro.Image = UploadImage(Image);
                _context.Products.Add(pro);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Lấy sản phẩm theo Id
        public Product GetProductById(long id)
        {
            return _context.Products.SingleOrDefault(x => x.ID == id);
        }
        //Sửa sản phẩm
        public bool EditProduct(Product entity, IFormFile Image)
        {

            var pro = GetProductById(entity.ID);
            pro.Product_Name = entity.Product_Name;
            pro.Metatitle = Str_Metatitle(entity.Product_Name);
            pro.Promotion_Price = entity.Promotion_Price;
            pro.Price = entity.Price;
            pro.Category_ID = entity.Category_ID;
            pro.Quantity = entity.Quantity;
            try
            {
                //Xóa file cũ
                DeletePathOld(pro.Image);
                //Thêm hình ảnh
                pro.Image = UploadImage(Image);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                _context.SaveChanges();
                return false;
            }
        }
        //Xóa sản phẩm
        public bool DeleteProduct(long id)
        {
            try
            {
                var product = GetProductById(id);
                DeletePathOld(product.Image);
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //
        public List<string> GetNameProductByKey(string str)
        {
            var query = _context.Products.Where(x => x.Product_Name.Contains(str)).Select(x => x.Product_Name).ToList();
            return query;
        }

        public async Task<PagingResult<Product>> GetSearchAsync(string keyword, int page = 1, int pageSize = 5)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string[] key = keyword.Split(',').Select(x => x.Trim().ToLower()).ToArray();
                //string[] key = keyword.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                //var product_name = new List<Product>();//Tìm theo tên sản phẩm
                var products = _context.Products.Where(x => key.Contains(x.Product_Name.Trim().ToLower()));
                //foreach (var item in key)
                //{
                //    product_name = (from b in db.Products
                //                    where b.Product_Name.Contains(item)
                //                    select b).ToList();
                //}
                var result = await PagingResult<Product>.CreateAsync(products.AsNoTracking(), page, pageSize);
                return result;
            }
            return null;
        }
    }
}
