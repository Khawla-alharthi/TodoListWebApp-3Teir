using System.ComponentModel.DataAnnotations.Schema;
using TodoList.DAL.Models.Enums;

namespace TodoList.DAL.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PriorityStatus Priority { get; set; } = PriorityStatus.Low;
        public bool IsFinished { get; set; }
        public DateTime Deadline { get; set; }


        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }


        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
