using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace Softplan.Api2.Tests.Scenarios
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
        public async void CalculaJuros_Get_ReturnsOkResponse(string metodo)
        {
            const string GIT_URL = "https://github.com/charlesmendes13/softplan";

            var client = _factory.CreateClient();

            var request = new HttpRequestMessage(new HttpMethod(metodo), "/api/ShowMeTheCode");

            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Should().NotBeNull();

            var result = await response.Content.ReadAsStringAsync();

            result.Should().Be(GIT_URL);
        }
    }
}
