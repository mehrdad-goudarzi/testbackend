using System;

namespace MySystem.Services.Orders.Core.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }

        public Product(Guid id)
        {
            Id = id;
        }
    }
}