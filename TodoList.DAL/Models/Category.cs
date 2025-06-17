﻿namespace TodoList.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();

    }
}
