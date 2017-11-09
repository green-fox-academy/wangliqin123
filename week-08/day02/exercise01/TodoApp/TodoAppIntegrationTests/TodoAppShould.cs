using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TodoApp;
using TodoApp.Entities;
using TodoApp.Repositories;
using Xunit;
using System.Linq;

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

        [Fact]
        public async Task AddNewTodo()
        {
            var options = new DbContextOptionsBuilder<TodoContext>().UseInMemoryDatabase(databaseName: "TodosTestDb").Options;

            using (var dbContext = new TodoContext(options))
            {
                var todoRepository = new TodoRepository(dbContext);

                dbContext.Todos.Add(new Todo()
                {
                    Title = "eat",                  
                });
                dbContext.SaveChanges();

                string expected = "eat";
                var todo = await dbContext.Todos.FirstOrDefaultAsync(x => x.Title.Equals("eat"));
                Assert.Equal(expected, todo.Title);
            }             
        }
    }
}