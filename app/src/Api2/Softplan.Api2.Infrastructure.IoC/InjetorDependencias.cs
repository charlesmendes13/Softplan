using Softplan.Api2.Domain;
using Softplan.Api2.Application;
using Softplan.Api2.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Softplan.Api2.Infrastructure.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection container)
        {
            // Domain
            
            container.AddScoped<ICalculaJurosService, CalculaJurosService>();
            container.AddScoped<IShowMeTheCodeService, ShowMeTheCodeService>();

            // Application

            container.AddScoped<ICalculaJurosAppService, CalculaJurosAppService>();
            container.AddScoped<IShowMeTheCodeAppService, ShowMeTheCodeAppService>();

            // Infra

            container.AddScoped<ITaxaJurosService, TaxaJurosService>();

        }
    }
}
