using IntegrationTests.TestFixtures;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.Scenarios.Home
{
    [Collection("BaseCollection")]
    public class DoublingShould
    {
        private TestContext Context;

        public DoublingShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/rest/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
