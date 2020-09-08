using FluentAssertions;
using Xunit;
using Softplan.Api1.Domain;
using Softplan.Api1.Application;

namespace Softplan.Api1.Unit.Tests
{
    public class TaxaJurosAppServiceTests
    {
        private readonly TaxaJurosService _taxaJurosService;
        private readonly TaxaJurosAppService _taxaJurosAppService;

        public TaxaJurosAppServiceTests()
        {
            _taxaJurosService = new TaxaJurosService();
            _taxaJurosAppService = new TaxaJurosAppService(_taxaJurosService);
        }

        [Fact]
        public void Obter_Taxa_Juros()
        {
            var resultado = _taxaJurosAppService.Obter();

            resultado.Should().Be(0.01m);
        }
    }
}
