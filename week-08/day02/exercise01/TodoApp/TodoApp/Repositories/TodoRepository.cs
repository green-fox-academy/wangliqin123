﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetList()
        {
            return TodoContext.Todos.ToList();
        }

        public void AddTodo()
        {
            var todo = new Todo()
            {
                Title = "do homework",
                IsDone = true,
                IsUrgent = true
            };

            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }

        public Todo GetLastTodo()
        {
            return TodoContext.Todos.Last();
        }
    }
}
