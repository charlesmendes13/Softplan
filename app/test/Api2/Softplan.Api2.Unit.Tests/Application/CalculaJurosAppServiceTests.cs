using Moq;
using Xunit;
using System.Threading.Tasks;
using FluentAssertions;
using Softplan.Api2.Domain;
using Softplan.Api2.Application;

namespace Softplan.Api2.Unit.Tests
{
    public class CalculaJurosAppServiceTests
    {
        private readonly Mock<ITaxaJurosService> _taxaJurosService = new Mock<ITaxaJurosService>();
        private readonly CalculaJurosService _calculaJurosService;
        private readonly CalculaJurosAppService _calculaJurosAppService;

        public CalculaJurosAppServiceTests()
        {
            _taxaJurosService.Setup(x => x.ObterAsync()).Returns(Task.FromResult(0.01m));
            _calculaJurosService = new CalculaJurosService(_taxaJurosService.Object);
            _calculaJurosAppService = new CalculaJurosAppService(_calculaJurosService);
        }

        [Fact]
        public void Calcula_Juros_Async()
        {
            var resultado = _calculaJurosAppService.CalcularAsync(100, 5).GetAwaiter().GetResult();

            resultado.Should().Be((decimal)105.1);
        }
    }
}
