using Microsoft.EntityFrameworkCore;
using OnlineShop.DbContexts;
using OnlineShop.Entities;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class LookupServices
    {
        private OnlineShopDbContext _context;
        public LookupServices(OnlineShopDbContext context)
        {
            _context = context;
        }
        public List<Category> GetListCategories()
        {
            return _context.Categories.Where(x => x.Status == true).ToList();
        }
        public List<Product> GetProductsByCategoryId(long categoryId)
        {
            return _context.Products.Where(x => x.Status == true && x.Category_ID == categoryId).ToList();
        }
    }
}
