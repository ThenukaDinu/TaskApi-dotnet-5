using System;
using System.Collections.Generic;
using System.Text;
using TaskApi.Modals;

namespace TaskApi.Services.Todos
{
    public interface ITodoRepository
    {
        List<Todo> AllTodos(int authorId);
        Todo GetTodo(int authorId, int id);
    }
}
