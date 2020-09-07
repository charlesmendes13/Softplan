using System.Threading.Tasks;
using Softplan.Api2.Domain;

namespace Softplan.Api2.Application
{
    public class CalculaJurosAppService : ICalculaJurosAppService
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosAppService(ICalculaJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;
        }

        public async Task<decimal> CalcularAsync(decimal valorInicial, int meses)
        {
            return await _calculaJurosService.CalcularAsync(valorInicial, meses);
        }
    }
}
