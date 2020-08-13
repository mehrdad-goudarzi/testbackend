using System;
using System.Linq;
using System.Threading.Tasks;
using Convey.Persistence.MongoDB;
using MySystem.Services.Orders.Core.Entities;
using MySystem.Services.Orders.Core.Repositories;
using MySystem.Services.Orders.Infrastructure.Mongo.Documents;

namespace MySystem.Services.Orders.Infrastructure.Mongo.Repositories
{
    public class OrderMongoRepository : IOrderRepository
    {
        private readonly IMongoRepository<OrderDocument, Guid> _repository;

        public OrderMongoRepository(IMongoRepository<OrderDocument, Guid> repository)
        {
            _repository = repository;
        }

        public Task AddAsync(Order order) => _repository.AddAsync(order.AsDocument());
    }
}