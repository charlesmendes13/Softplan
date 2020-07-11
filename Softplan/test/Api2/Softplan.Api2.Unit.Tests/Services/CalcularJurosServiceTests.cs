using FluentAssertions;
using Moq;
using Softplan.Api2.Application.Services;
using Softplan.Api2.Domain.Interfaces.Services;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.Api2.Unit.Tests.Services
{
    public class CalcularJurosServiceTests
    {
        private readonly Mock<ITaxaJurosService> _taxaJurosService = new Mock<ITaxaJurosService>();
        private readonly CalculaJurosService _calculaJurosService;

        public CalcularJurosServiceTests()
        {
            _taxaJurosService.Setup(x => x.ObterAsync()).Returns(Task.FromResult(0.01m));
            _calculaJurosService = new CalculaJurosService(_taxaJurosService.Object);
        }

        [Fact]
        public void Calcula_Juros_Async()
        {
            var resultado = _calculaJurosService.CalcularAsync(100, 5).GetAwaiter().GetResult();

            resultado.Should().Be((decimal)105.1);
        }
    }
}
