using OnlineShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using OnlineShop.Services;
using OnlineShop.DbContexts;
using OnlineShop.Services.Cartservice;

namespace ProductService.Services.Cartservice
{
    public class ProductService : IProductService
    {
        private readonly OnlineShopDbContext context;
        public ProductService(OnlineShopDbContext context)
        {
            this.context = context;
        }

        public async Task<Product> Create(Product createProduct)
        {
            try
            {
                context.Add(createProduct);
                var productId = await context.SaveChangesAsync();
                createProduct.ID = productId;
                return createProduct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await context.Products.Include(c => c.Category).FirstOrDefaultAsync(b => b.ID == productId);
        }

        public async Task<Product> Modify(Product product)
        {
            try
            {
                context.Attach(product);
                context.Entry<Product>(product).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> Remove(int productId)
        {
            try
            {
                var product = await GetProductById(productId);
                product.Status = true;
                context.Attach(product);
                context.Entry<Product>(product).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> Restore(int productId)
        {
            try
            {
                var product = await GetProductById(productId);
                product.Status = false;
                context.Attach(product);
                context.Entry<Product>(product).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
