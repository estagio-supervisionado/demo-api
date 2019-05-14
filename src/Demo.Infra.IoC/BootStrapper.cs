using Demo.Domain.Documentos;
using Demo.Domain.Interfaces.Services;
using Demo.Domain.Interfaces.Solr;
using Demo.Domain.Services;
using Demo.Infra.Data.Solr;
using Microsoft.Extensions.DependencyInjection;
using SolrNet;

namespace Demo.Infra.IoC
{
    public static class BootStrapper
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            return services
                .RegisterSolrDependencies()
                .RegisterLocalDependencies();
        }

        public static IServiceCollection RegisterLocalDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentoService, DocumentService>();
            return services;
        }

        public static IServiceCollection RegisterSolrDependencies(this IServiceCollection services)
        {
            services.AddSolrNet("http://localhost:8983/solr");
            services.AddSolrNet<Acordao>("http://localhost:8983/solr/documento");
            services.AddScoped<IAcordaoData, AcordaoData>();

            return services;
        }
    }
}
