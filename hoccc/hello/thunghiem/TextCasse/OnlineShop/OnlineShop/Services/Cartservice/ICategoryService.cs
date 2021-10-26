using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryById(int categoryId);
    }
}
