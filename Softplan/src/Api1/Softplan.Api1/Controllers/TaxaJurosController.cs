using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Softplan.Api1.Domain.Interfaces.Services;

namespace Softplan.Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }
        
        [HttpGet]
        public ActionResult<decimal> ObterTaxaJuros()
        {
            return _taxaJurosService.Obter();
        }
    }
}
