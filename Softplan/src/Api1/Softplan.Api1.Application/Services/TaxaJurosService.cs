using Softplan.Api1.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api1.Application.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public TaxaJurosService()
        {
        }

        public decimal Obter()
        {
            var taxa = (1 / 100m);

            return taxa;
        }
    }
}
