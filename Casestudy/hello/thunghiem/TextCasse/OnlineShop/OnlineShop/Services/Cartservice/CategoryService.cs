using OnlineShop.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Services;
using OnlineShop.DbContexts;

namespace OnlineShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly OnlineShopDbContext context;
        public CategoryService(OnlineShopDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            try
            {
                var response = await context.Categories.Include(b => b.Products).Where(c => c.Status).ToListAsync();
                return response;

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await context.Categories.Include(b => b.Products).FirstOrDefaultAsync(c => c.ID == categoryId);
        }
    }
}
