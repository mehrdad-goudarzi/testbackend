using MySystem.Services.StoreHouse.Application;

namespace MySystem.Services.StoreHouse.Infrastructure
{
    public interface IAppContextFactory
    {
        IAppContext Create();
    }
}