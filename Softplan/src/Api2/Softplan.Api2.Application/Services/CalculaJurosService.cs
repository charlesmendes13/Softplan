using Softplan.Api2.Application.Extensions;
using Softplan.Api2.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Softplan.Api2.Application.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly IApi1Service _api1Service;

        public CalculaJurosService(IApi1Service api1Service)
        {
            _api1Service = api1Service;
        }

        public async Task<decimal> CalcularAsync(decimal valorInicial, int meses)
        {
            var juros = await _api1Service.ObterTaxaJurosAsync();

            var calculo = (decimal)Math.Pow((double)(1 + juros), meses);
            calculo = valorInicial * calculo;

            return calculo.TruncateDecimal(2);
        }
    }
}
