using System;
using System.Threading.Tasks;
using Convey.Persistence.MongoDB;
using MySystem.Services.StoreHouse.Core.Entities;
using MySystem.Services.StoreHouse.Core.Repositories;
using MySystem.Services.StoreHouse.Infrastructure.Mongo.Documents;

namespace MySystem.Services.StoreHouse.Infrastructure.Mongo.Repositories
{
    public class ProductMongoRepository : IProductRepository
    {
        private readonly IMongoRepository<ProductDocument, Guid> _repository;

        public ProductMongoRepository(IMongoRepository<ProductDocument, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<Product> GetAsync(Guid id)
        {
            var entity = await _repository.GetAsync(id);

            return entity?.AsEntity();
        }

        public Task UpdateAsync(Product product)
        {
            return _repository.UpdateAsync(product.AsDocument());
        }
    }
}