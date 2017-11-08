//using Frontend.Controllers;
//using IntegrationTests.TestFixtures;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace IntegrationTests.Scenarios.Home
//{
//    [Collection("BaseCollection")]
//    public class DoublingShould
//    {
//        private TestContext Context;
        

//        public DoublingShould(TestContext context)
//        {
//            Context = context;
//        }

//        [Fact]
//        public async Task ReturnOkStatusWithoutInput()
//        {
//            var response = await Context.Client.GetAsync("/doubling");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnOkStatusWithInputNumber()
//        {
//            var response = await Context.Client.GetAsync("/doubling?input=5");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnOkStatusWithInputNull()
//        {
//            var response = await Context.Client.GetAsync("/doubling?input=");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnNotFoundStatusWithWrongRoute()
//        {
//            var response = await Context.Client.GetAsync("/doublin");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
//        }

//    }
//}