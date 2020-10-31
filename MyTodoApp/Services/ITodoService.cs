using MyTodoApp.Entities;
using System.Collections.Generic;

namespace MyTodoApp.Services
{
    public interface ITodoService
    {
        void Add(Todo todo);
        List<Todo> Todos { get; set; }
    }
}
