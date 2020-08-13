using System;
using System.Threading.Tasks;
using MySystem.Services.Orders.Core.Entities;

namespace MySystem.Services.Orders.Core.Repositories
{
    public interface IProductRepository
    {
        Task<bool> ExistsAsync(Guid id);
        Task AddAsync(Product customer);
    }
}