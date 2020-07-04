using System.Net;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace Softplan.Api1.Tests.Scenarios
{
    public class TaxaJurosTests
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public TaxaJurosTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("GET")]
        public async Task TaxaJuros_Get_ReturnsOkResponse(string metodo)
        {
            var client = _factory.CreateClient();

            var request = new HttpRequestMessage(new HttpMethod(metodo), "/api/TaxaJuros");

            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Should().NotBeNull();
        }
    }
}
