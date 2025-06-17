using ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppController : Controller
    {
        private Todo _todo;
        
        public AppController(Todo todo)
        {
            _todo = todo;
        }

        [HttpGet("todoList")]
        public IActionResult TodoList()
        {
            return Ok(_todo.GetTodoList());
        }

        [HttpPost("todoList/addTask")]
        public IActionResult AddTask([FromBody] string task)
        {
           return Ok(_todo.AddTask(task));
        }

        [HttpDelete("todoList/removeTask/{id}")]
        public IActionResult RemoveTask([FromBody] int taskId)
        {
            return Ok(_todo.RemoveTask(taskId));
        }

        [HttpPatch("todoList/updateTask/{id}")]
        public IActionResult UpdateTask([FromBody] int taskId)
        {
            return Ok(_todo.ToggleTask(taskId));
        }
    }
}