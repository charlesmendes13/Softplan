using Softplan.Api2.Domain.Interfaces.Services;
using Softplan.Api2.Application.Services;
using Softplan.Api2.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Softplan.Api2.Infrastructure.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection container)
        {
            // Services

            container.AddScoped<ITaxaJurosService, TaxaJurosService>();
            container.AddScoped<ICalculaJurosService, CalculaJurosService>();
            container.AddScoped<IShowMeTheCodeService, ShowMeTheCodeService>();            
        }
    }
}
