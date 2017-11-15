using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace GrootApp.IntegrationTests
{
    public class GuardianTests
    {
        private readonly HttpClient Client;
        private readonly TestServer Server;

        public GuardianTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnExpectedResponse()
        {
            var response = await Client.GetAsync("/groot?message");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":\"message\",\"translated\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnExpectedResponseShorter()
        {
            string test = await Client.GetStringAsync("/groot?message=message");

            Assert.Equal("{\"received\":\"message\",\"translated\":\"I am Groot!\"}", test);
        }                 

        [Fact]
        public async Task IndexShouldReturnStatusOkWithErroreMessage()
        {
            var response = await Client.GetAsync("/groot");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }
    }
}