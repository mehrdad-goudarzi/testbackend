using System;
using Convey.CQRS.Events;

namespace MySystem.Services.Orders.Application.Events.Rejected
{
    [Contract]
    public class CreateOrderRejected : IRejectedEvent
    {
        public string Reason { get; }
        public string Code { get; }

        public CreateOrderRejected(string reason, string code)
        {
            Reason = reason;
            Code = code;
        }
    }
}