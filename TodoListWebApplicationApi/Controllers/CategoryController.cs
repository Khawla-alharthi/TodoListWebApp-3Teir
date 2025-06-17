using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DAL.Context;
using TodoList.DAL.Models;

namespace TodoListWebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name=("GetCategories"))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetCategories()
        {
            var categories = _context.Categories.ToList();
            if(categories.Count == 0)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public ActionResult GetCategory(int id)
        {
            var cat = _context.Categories.SingleOrDefault(c => c.Id == id);
            if (cat == null)
            {
                return NotFound();
            }
            return Ok(cat);
        }


        [HttpPost(Name = "CreateCategory")]
        public ActionResult CreateCategory([FromBody] Category category)
        {
            if (category == null || string.IsNullOrEmpty(category.Name))
            {
                return BadRequest("Invalid category data.");
            }
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok(category);
        }



        [HttpPut("{id}", Name = "UpdateCategory")]
        public ActionResult UpdateCategory(int id, [FromBody] Category category)
        {
            if (id == 0 || id != category.Id || category == null || string.IsNullOrEmpty(category.Name))
            {
                return BadRequest("Invalid category data.");
            }
            var existingCategory = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;
            _context.Categories.Update(existingCategory);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}", Name = "DeleteCategory")]
        public ActionResult DeleteCategory(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(c=> c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
