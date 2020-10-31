using MyTodoApp.Entities;
using System.Collections.Generic;

namespace MyTodoApp.Services
{
    public class TodoService : ITodoService
    {
        public TodoService()
        {
            Todos = new List<Todo>();
        }
        public List<Todo> Todos { get; set; }
        public void Add(Todo todo)
        {
            Todos.Add(todo);
        }
    }
}
