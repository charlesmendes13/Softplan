using FluentAssertions;
using Softplan.Api2.Application.Services;
using Xunit;

namespace Softplan.Api2.Unit.Tests.Services
{
    public class ShowMeTheCodeServiceTests
    {
        private readonly ShowMeTheCodeService _showMeTheCodeService;

        public ShowMeTheCodeServiceTests()
        {
            _showMeTheCodeService = new ShowMeTheCodeService();
        }

        [Fact]
        public void Obter_Url_Git()
        {
            var resultado = _showMeTheCodeService.Obter();

            resultado.Should().Be("https://github.com/charlesmendes13/softplan");
        }
    }
}
