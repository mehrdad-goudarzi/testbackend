using System;
using System.Collections.Generic;
using Convey.Logging.CQRS;
using MySystem.Services.Orders.Application.Commands;
using MySystem.Services.Orders.Application.Events;

namespace MySystem.Services.Orders.Infrastructure.Logging
{
    internal sealed class MessageToLogTemplateMapper : IMessageToLogTemplateMapper
    {
        private static IReadOnlyDictionary<Type, HandlerLogTemplate> MessageTemplates 
            => new Dictionary<Type, HandlerLogTemplate>
            {
                {
                    typeof(CreateOrder),     
                    new HandlerLogTemplate
                    {
                        After = "Order with id: {OrderId} has been created."
                    }
                },
                {
                    typeof(OrderCreated),     
                    new HandlerLogTemplate
                    {
                        After = "Order with id: {Order.Id} has been created."
                    }
                }
            };
        
        public HandlerLogTemplate Map<TMessage>(TMessage message) where TMessage : class
        {
            var key = message.GetType();
            return MessageTemplates.TryGetValue(key, out var template) ? template : null;
        }
    }
}