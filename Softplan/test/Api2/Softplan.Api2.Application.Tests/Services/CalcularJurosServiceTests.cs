using FluentAssertions;
using Moq;
using Softplan.Api1.Application.Services;
using Softplan.Api2.Application.Services;
using Softplan.Api2.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.Api2.Application.Tests.Services
{
    public class CalcularJurosServiceTests
    {
        private readonly TaxaJurosService _taxaJurosService;
        private readonly CalculaJurosService _calculaJurosService;

        public CalcularJurosServiceTests()
        {
            _taxaJurosService = new TaxaJurosService();
            _calculaJurosService = new CalculaJurosService(_taxaJurosService);
        }

        [Fact]
        public void Calcula_Juros()
        {
            var resultado = _calculaJurosService.Calcular(100, 5);

            resultado.Should().Be((decimal)105.1);
        }
    }
}
