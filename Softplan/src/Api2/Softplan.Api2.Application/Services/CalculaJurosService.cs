using Softplan.Api2.Application.Extensions;
using Softplan.Api2.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Softplan.Api2.Application.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculaJurosService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public async Task<decimal> CalcularAsync(decimal valorInicial, int meses)
        {
            var juros = await _taxaJurosService.ObterAsync();

            var calculo = (decimal)Math.Pow((double)(1 + juros), meses);
            calculo = valorInicial * calculo;

            return calculo.TruncateDecimal(2);
        }
    }
}
