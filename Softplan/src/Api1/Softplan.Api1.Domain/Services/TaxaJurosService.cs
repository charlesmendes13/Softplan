using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Api1.Domain
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public decimal Obter()
        {
            var taxa = (1 / 100m);

            return taxa;
        }
    }
}
