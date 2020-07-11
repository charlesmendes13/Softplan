using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Softplan.Api2.Domain.Interfaces.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.Api2.Integration.Tests.Controllers
{
    public class CalculaJurosControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly Mock<ITaxaJurosService> _taxaJurosService = new Mock<ITaxaJurosService>();
        private readonly WebApplicationFactory<Startup> _factory;

        public CalculaJurosControllerTests(WebApplicationFactory<Startup> factory)
        {
            _taxaJurosService.Setup(x => x.ObterAsync()).Returns(Task.FromResult(0.01m));
            _factory = factory;
        }

        [Theory]
        [InlineData("GET", 100, 5)]
        public async void CalculaJuros_Get_Returns_Ok_Response(string metodo, decimal valorInicial, int meses)
        {           
            var client = _factory.WithWebHostBuilder(hostbuilder =>
            {
                hostbuilder.ConfigureTestServices((services) =>
                {
                    services.AddSingleton<ITaxaJurosService>(_taxaJurosService.Object);
                });
            })
            .CreateClient();

            var request = new HttpRequestMessage(new HttpMethod(metodo), $"/api/calculaJuros?valorInicial={valorInicial}&meses={meses}");

            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Should().NotBeNull();

            var result = await response.Content.ReadAsStringAsync();

            result.Should().Be("105.1");
        }
    }
}
