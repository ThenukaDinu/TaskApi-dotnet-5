using System;
using System.Collections.Generic;
using System.Text;
using TaskApi.Modals;

namespace TaskApi.Services
{
    public interface ITodoRepository
    {
        List<Todo> AllTodos();
    }
}
