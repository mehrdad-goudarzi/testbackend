using System;
using System.Threading.Tasks;
using MySystem.Services.StoreHouse.Core.Entities;

namespace MySystem.Services.StoreHouse.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetAsync(Guid id);
        Task UpdateAsync(Product product);
    }
}