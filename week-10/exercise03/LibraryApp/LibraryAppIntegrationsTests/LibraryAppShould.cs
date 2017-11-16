using LibraryApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace LibraryAppIntegrationsTests
{
    public class LibraryAppShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public LibraryAppShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkWithRouteBook()
        {
            var response = await Client.GetAsync("/book");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/book");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}