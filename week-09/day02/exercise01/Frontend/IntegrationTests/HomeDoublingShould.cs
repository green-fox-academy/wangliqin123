using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class HomeDoublingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public HomeDoublingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnResultWithInput3()
        {
            //var response = await Client.GetAsync("/doubling?input=5");

            //var responseJson = await response.Content.ReadAsStringAsync();

            //Assert.Equal("{\"received\":5,\"result\":10}", responseJson);


            string test = await Client.GetStringAsync("/doubling?input=5");

            Assert.Equal("{\"received\":5,\"result\":10}", test);
        }
    }
}
