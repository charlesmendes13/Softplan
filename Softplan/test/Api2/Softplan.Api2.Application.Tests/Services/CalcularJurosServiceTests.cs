using FluentAssertions;
using Moq;
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
        private readonly Mock<IApi1Service> _api1ServiceMock = new Mock<IApi1Service>();
        private readonly CalculaJurosService _calculaJurosService;

        public CalcularJurosServiceTests()
        {
            _api1ServiceMock.Setup(x => x.ObterTaxaJurosAsync()).Returns(Task.FromResult(0.01m));
            _calculaJurosService = new CalculaJurosService(_api1ServiceMock.Object);
        }

        [Fact]
        public void Calcula_Juros()
        {
            var resultado = _calculaJurosService.CalcularAsync(100, 5).GetAwaiter().GetResult();

            resultado.Should().Be((decimal)105.1);
        }
    }
}
