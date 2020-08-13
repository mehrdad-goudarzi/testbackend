using System;
using Convey.Types;

namespace MySystem.Services.StoreHouse.Infrastructure.Mongo.Documents
{
    public class ProductDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public long Inventory { get; set; }
    }
}