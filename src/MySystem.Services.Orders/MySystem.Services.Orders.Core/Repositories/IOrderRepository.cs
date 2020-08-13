using System;
using System.Threading.Tasks;
using MySystem.Services.Orders.Core.Entities;

namespace MySystem.Services.Orders.Core.Repositories
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
    }
}