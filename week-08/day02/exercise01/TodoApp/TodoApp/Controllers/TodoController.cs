using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Repositories;


namespace TodoApp.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {

        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/")]
        public IActionResult List()
        {
            TodoRepository.AddTodo();
            return RedirectToAction("List");
        }
    }
}