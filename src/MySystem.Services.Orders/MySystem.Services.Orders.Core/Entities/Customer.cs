using System;

namespace MySystem.Services.Orders.Core.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public Customer(Guid id)
        {
            Id = id;
        }
    }
}