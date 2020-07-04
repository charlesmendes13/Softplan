using Softplan.Api2.Application.Extensions;
using Softplan.Api2.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.Api2.Application.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly IApi1Service _api1Service;

        public CalculaJurosService(IApi1Service api1Service)
        {
            _api1Service = api1Service;
        }

        public async Task<decimal> CalcularAsync(decimal valorInicial, int meses)
        {
            var juros = await _api1Service.ObterTaxaJurosAsync();

            var resultado = (double)valorInicial * Math.Pow((double)juros + 1, meses);

            return ((decimal)resultado).TruncateDecimal(2);
        }
    }
}
