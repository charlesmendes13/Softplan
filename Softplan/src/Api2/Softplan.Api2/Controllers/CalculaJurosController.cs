using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Softplan.Api2.Application;

namespace Softplan.Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosAppService _calculaJurosAppService;

        public CalculaJurosController(ICalculaJurosAppService calculaJurosAppService)
        {
            _calculaJurosAppService = calculaJurosAppService;
        }

        [HttpGet]
        public async Task<decimal> CalcularJurosAsync([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            return await _calculaJurosAppService.CalcularAsync(valorInicial, meses);
        }
    }
}
