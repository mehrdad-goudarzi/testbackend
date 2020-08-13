using System;

namespace MySystem.Services.StoreHouse.Core.Exceptions
{
    public class InvalidAggregateIdException : DomainException
    {
        public override string Code { get; } = "invalid_aggregate_id";
        public Guid Id { get; }
        
        public InvalidAggregateIdException(Guid id) : base($"Invalid aggregate id.")
        {
            Id = id;
        }
    }
}