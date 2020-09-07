using Softplan.Api1.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api1.Application
{
    public class TaxaJurosAppService : ITaxaJurosAppService
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosAppService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public decimal Obter()
        {
            return _taxaJurosService.Obter();
        }
    }
}
