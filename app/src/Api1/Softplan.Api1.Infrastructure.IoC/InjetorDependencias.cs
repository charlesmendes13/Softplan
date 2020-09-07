using Microsoft.Extensions.DependencyInjection;
using Softplan.Api1.Application;
using Softplan.Api1.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api1.Infrastructure.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection container)
        {
            // Domain

            container.AddScoped<ITaxaJurosService, TaxaJurosService>();

            // Application

            container.AddScoped<ITaxaJurosAppService, TaxaJurosAppService>();
        }
    }
}
