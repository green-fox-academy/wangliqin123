using Frontend.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
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
        public async Task ReturnErrorMessageWithNullContent()
        {
            var data = new StringContent(content: "", encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil/sum", data);
            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }

        [Fact]
        public async Task ReturnErrorMessageWithNullString()
        {
            var data = new StringContent(content: "", encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil", data);
            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}