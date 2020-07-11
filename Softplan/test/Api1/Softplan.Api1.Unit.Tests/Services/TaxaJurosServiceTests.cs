using FluentAssertions;
using Softplan.Api1.Application.Services;
using Xunit;

namespace Softplan.Api1.Unit.Tests.Services
{
    public class TaxaJurosServiceTests
    {
        private readonly TaxaJurosService _taxaJurosService;

        public TaxaJurosServiceTests()
        {
            _taxaJurosService = new TaxaJurosService();
        }

        [Fact]
        public void Obter_Taxa_Juros()
        {
            var resultado = _taxaJurosService.Obter();

            resultado.Should().Be(0.01m);
        }
    }
}
