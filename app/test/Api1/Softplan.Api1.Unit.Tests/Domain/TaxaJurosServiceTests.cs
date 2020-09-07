using Xunit;
using FluentAssertions;
using Softplan.Api1.Domain;

namespace Softplan.Api1.Unit.Tests
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
