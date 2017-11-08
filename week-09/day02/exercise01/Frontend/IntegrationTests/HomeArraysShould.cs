using Frontend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.IntegrationTests
{
    public class HomeArraysShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public HomeArraysShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnResultWithSum2510()
        {
            var usedArray = new MyArray
            {
                what = "sum",
                numbers = new int[] { 2, 5, 10 }
            };
            var convertedUsedUntil = JsonConvert.SerializeObject(usedArray);
            var data = new StringContent(convertedUsedUntil.ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("arrays", data);

            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":17}", responseJson);
        }
    }        
}