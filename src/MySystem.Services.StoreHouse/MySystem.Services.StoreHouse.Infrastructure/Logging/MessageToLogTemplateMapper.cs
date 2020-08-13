using System;
using System.Collections.Generic;
using Convey.Logging.CQRS;
using MySystem.Services.StoreHouse.Application.Events;

namespace MySystem.Services.StoreHouse.Infrastructure.Logging
{
    internal sealed class MessageToLogTemplateMapper : IMessageToLogTemplateMapper
    {
        private static IReadOnlyDictionary<Type, HandlerLogTemplate> MessageTemplates 
            => new Dictionary<Type, HandlerLogTemplate>
            {
                {
                    typeof(InventoryDecreased),     
                    new HandlerLogTemplate
                    {
                        After = "Product with id: {ProductId} has been updated."
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