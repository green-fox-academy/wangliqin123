using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TodoApp;
using Xunit;

namespace TodoAppIntegrationTests
{
    public class TodoAppShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public TodoAppShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnNotFoundStatusWithWrongRoute()
        {
            var response = await Client.GetAsync("/tod");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}