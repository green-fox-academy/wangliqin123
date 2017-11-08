//using IntegrationTests.TestFixtures;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace IntegrationTests.Scenarios.Home
//{
//    [Collection("BaseCollection")]
//    public class GreeterShould
//    {
//        private TestContext Context;

//        public GreeterShould(TestContext context)
//        {
//            Context = context;
//        }

//        [Fact]
//        public async Task ReturnOkStatusWithoutInput()
//        {
//            var response = await Context.Client.GetAsync("/greeter");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnNotFoundStatusWithWrongRoute()
//        {
//            var response = await Context.Client.GetAsync("/greet");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnNotFoundStatusWithBothInput()
//        {
//            var response = await Context.Client.GetAsync("/greeter?name=Laci?title=student");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnNotFoundStatusWithOnlyNameInput()
//        {
//            var response = await Context.Client.GetAsync("/greeter?name=Laci?title=");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnOkStatusWithBothInputNull()
//        {
//            var response = await Context.Client.GetAsync("/greeter?name=?title=");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }
//    }
//}
