using System.Threading.Tasks;

namespace Softplan.Api2.Domain
{
    public interface ITaxaJurosService
    {
        Task<decimal> ObterAsync();
    }
}
