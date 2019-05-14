using Demo.Infra.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Api.Extensions
{
    public static class ServiceCollectionExtensionsMethods
    {
        public static IServiceCollection CreateServices(this IServiceCollection service)
        {
            service.RegisterDependencies();
            return service;
        }
    }
}
