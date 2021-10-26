using OnlineShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Services.Cartservice
{
    public interface IProductService
    {
        Task<Product> Create(Product createBook);
        Task<Product> GetProductById(int bookId);
        Task<Product> Modify(Product book);
        Task<Product> Remove(int bookId);
        Task<Product> Restore(int bookId);
    }
}
