using Softplan.Api2.Domain.Interfaces.Services;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Softplan.Api2.Infrastructure.CrossCutting.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TaxaJurosService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<decimal> ObterAsync()
        {
            var client = _httpClientFactory.CreateClient("Api1");
            var response = await client.GetAsync("api/TaxaJuros");

            return JsonConvert.DeserializeObject<decimal>(await response.Content.ReadAsStringAsync());
        }
    }
}
