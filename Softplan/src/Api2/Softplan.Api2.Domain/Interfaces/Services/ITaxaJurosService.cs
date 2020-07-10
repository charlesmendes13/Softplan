using System.Threading.Tasks;

namespace Softplan.Api2.Domain.Interfaces.Services
{
    public interface ITaxaJurosService
    {
        Task<decimal> ObterAsync();
    }
}
