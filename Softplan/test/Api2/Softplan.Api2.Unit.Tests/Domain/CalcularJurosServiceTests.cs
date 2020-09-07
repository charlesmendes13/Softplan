using Moq;
using Xunit;
using System.Threading.Tasks;
using FluentAssertions;
using Softplan.Api2.Domain;

namespace Softplan.Api2.Unit.Tests.Domain
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
