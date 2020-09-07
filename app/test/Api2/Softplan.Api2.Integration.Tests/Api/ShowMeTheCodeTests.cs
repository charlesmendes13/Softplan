using Xunit;
using FluentAssertions;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Softplan.Api2.Integration.Tests
{
    public class ShowMeTheCodeTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ShowMeTheCodeTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("GET")]
        public async void CalculaJuros_Get_Returns_Ok_Response(string metodo)
        {
            var client = _factory.CreateClient();

            var request = new HttpRequestMessage(new HttpMethod(metodo), "/api/ShowMeTheCode");

            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Should().NotBeNull();

            var result = await response.Content.ReadAsStringAsync();

            result.Should().Be("https://github.com/charlesmendes13/softplan");
        }
    }
}
