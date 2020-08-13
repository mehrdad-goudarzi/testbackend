using System;
using Convey.Types;

namespace MySystem.Services.Orders.Infrastructure.Mongo.Documents
{
    public class ProductDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
    }
}