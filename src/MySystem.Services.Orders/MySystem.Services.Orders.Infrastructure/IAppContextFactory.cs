using MySystem.Services.Orders.Application;

namespace MySystem.Services.Orders.Infrastructure
{
    public interface IAppContextFactory
    {
        IAppContext Create();
    }
}