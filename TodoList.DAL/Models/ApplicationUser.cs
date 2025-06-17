using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace TodoList.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }


        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
