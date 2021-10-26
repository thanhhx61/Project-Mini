using Microsoft.EntityFrameworkCore;
using OnlineShop.DbContexts;
using OnlineShop.Entities;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OnlineShop.Helper.Helper;

namespace OnlineShop.Services
{
    public class CategoryServices
    {
        private OnlineShopDbContext _context;
        public CategoryServices(OnlineShopDbContext context)
        {
            _context = context;
        }
        public async Task<PagingResult<Category>> GetCategories(int page = 1, int pageSize = 10)
        {
            var model = _context.Categories.Where(x => x.Status == true).OrderByDescending(x => x.ID);
            var resutl = await PagingResult<Category>.CreateAsync(model.AsNoTracking(), page, pageSize);
            return resutl;
        }

        public bool CreateCategory(Category entity)
        {
            try
            {
                var prv = new Category();
                prv.Name = entity.Name;
                prv.Link = Str_Metatitle(entity.Name);
                prv.Status = true;
                _context.Categories.Add(prv);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCategory(Category entity)
        {
            try
            {
                var prv = _context.Categories.Find(entity.ID);
                prv.Name = entity.Name;
                prv.Link = Str_Metatitle(entity.Name);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Category GetCategoryById(long id)
        {
            return _context.Categories.SingleOrDefault(x=>x.ID == id);
        }
        public bool DeleteCategory(long id)
        {
            try
            {
                var cate = GetCategoryById(id);
                _context.Categories.Remove(cate);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
