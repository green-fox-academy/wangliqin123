using Frontend.Controllers;
using Frontend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
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
        public async Task ReturnErrorMessageWithNullInputSum()
        {
            var data = new StringContent(content: "", encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil/sum", data);
            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }

        [Fact]
        public async Task ReturnErrorMessageWithOutWhat()
        {
            var usedUntil = new DoUntil
            {
                Until = 5,
            };
            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil", data);
            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnResultWithUntil5()
        {
            var usedUntil = new DoUntil
            {
                Until = 5,
            };
            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil/sum", data);

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":15}", responseJson);
        }
    }
}