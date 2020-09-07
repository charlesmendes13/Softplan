using System.Threading.Tasks;

namespace Softplan.Api2.Domain
{
    public interface ICalculaJurosService
    {
        Task<decimal> CalcularAsync(decimal valorInicial, int meses);
    }
}
