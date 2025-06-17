using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DAL.Context;
using TodoList.DAL.Models;

namespace TodoListWebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = ("GetTodos"))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetTodos()
        {
            var todo = _context.ToDos.ToList();
            if (todo.Count == 0)
            {
                return NotFound();
            }
            return Ok(todo);
        }


        [HttpGet("{id}", Name = ("GetTodo"))]
        public ActionResult GetTodo(int id)
        {
            var todo = _context.ToDos.SingleOrDefault(c => c.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }


        [HttpPost(Name = "CreateTodo")]
        public ActionResult CreateTodo([FromBody] Todo todo)
        {
            if (todo == null || string.IsNullOrEmpty(todo.Name))
            {
                return BadRequest("Invalid todo data.");
            }
            _context.ToDos.Add(todo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
        }



        [HttpPut("{id}", Name = "UpdateTodo")]
        public ActionResult UpdateTodo(int id, [FromBody] Todo todo)
        {
            if (id == 0 || id != todo.Id || todo == null || string.IsNullOrEmpty(todo.Name))
            {
                return BadRequest("Invalid todo data.");
            }
            var existingTodo = _context.ToDos.FirstOrDefault(c => c.Id == id);
            if (existingTodo == null)
            {
                return NotFound();
            }

            existingTodo.Name = todo.Name;
            existingTodo.Description = todo.Description;
            existingTodo.Deadline = todo.Deadline;
            existingTodo.IsFinished = todo.IsFinished;
            existingTodo.Priority = todo.Priority;
            existingTodo.CategoryId = todo.CategoryId;

            _context.ToDos.Update(existingTodo);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpPost("{id}", Name = "DeleteTodo")]
        public ActionResult DeleteTodo(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var todo = _context.ToDos.FirstOrDefault(c => c.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            _context.ToDos.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
