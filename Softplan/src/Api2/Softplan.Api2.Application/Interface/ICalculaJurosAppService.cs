using System.Threading.Tasks;

namespace Softplan.Api2.Application
{
    public interface ICalculaJurosAppService
    {
        Task<decimal> CalcularAsync(decimal valorInicial, int meses);
    }
}
