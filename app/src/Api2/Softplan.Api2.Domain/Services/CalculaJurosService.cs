using System;
using System.Threading.Tasks;

namespace Softplan.Api2.Domain
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

            var step = (decimal)Math.Pow(10, 2);
            var tmp = Math.Truncate(step * calculo);

            return tmp / step;
        }
    }
}
