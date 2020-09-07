using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Softplan.Api1.Application;

namespace Softplan.Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAppService _taxaJurosAppService;

        public TaxaJurosController(ITaxaJurosAppService taxaJurosAppService)
        {
            _taxaJurosAppService = taxaJurosAppService;
        }
        
        [HttpGet]
        public ActionResult<decimal> ObterTaxaJuros()
        {
            return _taxaJurosAppService.Obter();
        }
    }
}
