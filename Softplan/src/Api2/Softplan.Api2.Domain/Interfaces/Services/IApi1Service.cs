using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.Api2.Domain.Interfaces.Services
{
    public interface IApi1Service
    {
        Task<decimal> ObterTaxaJurosAsync();
    }
}
