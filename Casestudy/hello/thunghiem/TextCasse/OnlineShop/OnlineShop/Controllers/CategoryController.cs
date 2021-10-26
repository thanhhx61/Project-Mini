using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DbContexts;
using OnlineShop.Entities;
using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryServices _categoryServices;
        private LookupServices _lookupServices;
        public CategoryController(CategoryServices categoryServices, LookupServices lookupServices)
        {
            _categoryServices = categoryServices;
            _lookupServices = lookupServices;
        }
        // GET: Category
        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            var data = await _categoryServices.GetCategories(page, pageSize);
            foreach (var item in data)
            {
                item.CountProduct = _lookupServices.GetProductsByCategoryId(item.ID).Count;
            }
            return View(data);
        }

        public IActionResult Delete(long ID)
        {

            var result = _categoryServices.DeleteCategory(ID);
            return Ok(new
            {
                status = result
            });
        }


        [HttpPost]
        public ActionResult addCate(Category entity)
        {
            var result = _categoryServices.CreateCategory(entity);
            if (result)
            {
                TempData["add_success"] = "Thêm danh mục sản phẩm thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["add_success"] = "Thêm danh mục sản phẩm KHÔNG thành công";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult editCate(Category entity)
        {
            var result = _categoryServices.EditCategory(entity);
            if (result)
            {
                TempData["add_success"] = "Sửa danh mục sản phẩm thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["add_success"] = "Sửa danh mục sản phẩm KHÔNG thành công";
                return RedirectToAction("Index");
            }
        }

        public IActionResult GetCateByID(long ID)
        {
            var cate = _categoryServices.GetCategoryById(ID);
            return Ok(cate);
        }
    }
}
