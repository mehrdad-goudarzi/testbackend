using System;
using Convey.Types;

namespace MySystem.Services.Orders.Infrastructure.Mongo.Documents
{
    public class CustomerDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
    }
}