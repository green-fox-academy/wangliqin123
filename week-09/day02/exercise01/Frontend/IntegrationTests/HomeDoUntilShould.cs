using Frontend.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.IntegrationTests
{
    public class HomeDoUntilShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public HomeDoUntilShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("rest/dountil/hellaaoouu");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}