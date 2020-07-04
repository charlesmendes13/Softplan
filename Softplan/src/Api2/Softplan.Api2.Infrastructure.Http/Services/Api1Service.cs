using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Softplan.Api2.Domain.Interfaces.Services;
using Softplan.Api2.Infrastructure.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Softplan.Api2.Infrastructure.Http.Services
{
    public class Api1Service : IApi1Service
    {
        public async Task<decimal> ObterTaxaJurosAsync()
        {
            var url = "https://localhost:44369/api/TaxaJuros/";

            var response = await RequestHttpExtensions.Request(url);

            decimal taxa = JsonSerializer.Deserialize<decimal>(response);

            return taxa;
        }
    }
}