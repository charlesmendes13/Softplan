using Microsoft.Extensions.DependencyInjection;
using Softplan.Api1.Application.Services;
using Softplan.Api1.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api1.Infrastructure.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection container)
        {
            // Services

            container.AddScoped<ITaxaJurosService, TaxaJurosService>();           
        }
    }
}
