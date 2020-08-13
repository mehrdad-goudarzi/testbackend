using System;
using Convey.MessageBrokers.RabbitMQ;
using MySystem.Services.Orders.Application.Events.Rejected;
using MySystem.Services.Orders.Core.Exceptions;

namespace MySystem.Services.Orders.Infrastructure.Exceptions
{
    public class ExceptionToMessageMapper : IExceptionToMessageMapper
    {
        public object Map(Exception exception, object message)
            => exception switch
            {
                ProductNotFoundException ex => (object)new CreateOrderRejected(ex.Message, ex.Code),
                CustomerNotFoundException ex => new CreateOrderRejected(ex.Message, ex.Code),
                _ => null,
            };
    }
}