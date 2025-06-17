using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;
using TodoList.DAL.Models;


namespace TodoList.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Todo> ToDos { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
