using Xunit;
using FluentAssertions;
using Softplan.Api2.Domain;
using Softplan.Api2.Application;

namespace Softplan.Api2.Unit.Tests
{
    public class ShowMeTheCodeAppServiceTests
    {
        private readonly ShowMeTheCodeService _showMeTheCodeService;
        private readonly ShowMeTheCodeAppService _showMeTheCodeAppService;

        public ShowMeTheCodeAppServiceTests()
        {
            _showMeTheCodeService = new ShowMeTheCodeService();
            _showMeTheCodeAppService = new ShowMeTheCodeAppService(_showMeTheCodeService);
        }

        [Fact]
        public void Obter_Url_Git()
        {
            var resultado = _showMeTheCodeAppService.Obter();

            resultado.Should().Be("https://github.com/charlesmendes13/softplan");
        }
    }
}
