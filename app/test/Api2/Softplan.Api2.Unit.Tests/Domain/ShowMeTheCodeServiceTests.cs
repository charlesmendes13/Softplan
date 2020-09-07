using Xunit;
using FluentAssertions;
using Softplan.Api2.Domain;

namespace Softplan.Api2.Unit.Tests
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
