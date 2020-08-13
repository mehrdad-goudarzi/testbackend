using MySystem.Services.StoreHouse.Core.Entities;

namespace MySystem.Services.StoreHouse.Infrastructure.Mongo.Documents
{
    public static class Extensions
    {
        public static Product AsEntity(this ProductDocument document)
            => new Product(document.Id, document.Inventory);

        public static ProductDocument AsDocument(this Product entity)
            => new ProductDocument
            {
                Id = entity.Id,
                Inventory = entity.Inventory
            };
    }
}