using System;
using System.Collections.Generic;
using Convey.Types;
using MySystem.Services.Orders.Core.Entities;

namespace MySystem.Services.Orders.Infrastructure.Mongo.Documents
{
    public class OrderDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public long Count { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}