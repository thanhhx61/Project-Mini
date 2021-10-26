using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DbContexts;
using OnlineShop.Entities;
using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private ProductServices _productServices;
        private LookupServices _lookupServices;
        public ProductController(ProductServices productServices, LookupServices lookupServices)
        {
            _productServices = productServices;
            _lookupServices = lookupServices;
        }
        // GET: Product
        public async Task<IActionResult> Index(int page = 1, int pageSize = 5)
        {
            return View(await _productServices.GetProcducts(page, pageSize));
        }
        // GET: Admin/Product/Create
        public ActionResult Add()
        {
            ViewBag.lstCategory = _lookupServices.GetListCategories();
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(Product entity, IFormFile Image)
        {
            var resutl = _productServices.CreateProduct(entity, Image);
            if (resutl)
            {
                TempData["add_success"] = "Thêm sản phẩm thành công.";

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Add");
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(long ID)
        {
            ViewBag.product = _productServices.GetProductById(ID);
            ViewBag.lstCategory = _lookupServices.GetListCategories();
            return View();
        }

        //POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product entity, IFormFile Image)
        {
            var result = _productServices.EditProduct(entity, Image);
            TempData["add_success"] = result ? "Sửa sản phẩm thành công." : "";
            return RedirectToAction("Index");
        }

        // GET: Admin/Product/Delete/5
        public IActionResult Delete(long ID)
        {
            var result = _productServices.DeleteProduct(ID);
            return Ok(new
            {
                status = result
            });
        }

        public IActionResult ListName(string q)
        {
            var result = _productServices.GetNameProductByKey(q);
            return Ok(new
            {
                data = result,
                status = true
            });
        }

        public async Task<ActionResult> Search(string keyword, int page = 1, int pagesize = 5)
        {
            ViewBag.KeyWord = keyword;
            var result = await _productServices.GetSearchAsync(keyword, page, pagesize);
            if(result != null)
            {
                return View(result);
            }
            return View();
        }
    }

}
