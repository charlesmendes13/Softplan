using FluentAssertions;
using Softplan.Api2.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Softplan.Api2.Application.Tests.Services
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
            const string GIT_URL = "https://github.com/charlesmendes13/softplan";

            var resultado = _showMeTheCodeService.Obter();

            resultado.Should().Be(GIT_URL);
        }
    }
}
