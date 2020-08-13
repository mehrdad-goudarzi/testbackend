using System;
using System.Threading.Tasks;
using MySystem.Services.Orders.Core.Entities;

namespace MySystem.Services.Orders.Core.Repositories
{
    public interface ICustomerRepository
    {
        Task<bool> ExistsAsync(Guid id);
        Task AddAsync(Customer customer);
    }
}