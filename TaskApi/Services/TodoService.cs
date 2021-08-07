using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Modals;

namespace TaskApi.Services
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                States = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Practice guitar",
                Description = "practice guitar for 30 minutes",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                States = TodoStatus.New
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Shopping groceries for next week",
                Description = "buy items needed for next week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                States = TodoStatus.InProgress
            };
            todos.Add(todo3);

            var todo4 = new Todo
            {
                Id = 4,
                Title = "Practice algorithms",
                Description = "Practice algorithms and data structures using code wars",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(6),
                States = TodoStatus.Completed
            };
            todos.Add(todo4);

            var todo5 = new Todo
            {
                Id = 5,
                Title = "Finish workout",
                Description = "Finish daily workout",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                States = TodoStatus.New
            };
            todos.Add(todo5);

            return todos;
        }
    }
}
