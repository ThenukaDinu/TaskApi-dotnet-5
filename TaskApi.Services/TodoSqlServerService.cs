using System;
using System.Collections.Generic;
using System.Text;
using TaskApi.Modals;
using TaskApi.DataAccess;
using System.Linq;

namespace TaskApi.Services
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
