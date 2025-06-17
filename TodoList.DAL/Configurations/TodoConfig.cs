using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TodoList.DAL.Models;

namespace TodoListWebApplicationApi.Configurations
{
    public class TodoConfig : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("ToDos")
                .HasKey(t => t.Id);
            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(t => t.Priority)
                .IsRequired();
            builder.Property(t => t.IsFinished)
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property(t => t.Deadline)
                .IsRequired();
            builder.HasOne(t => t.Category)
                .WithMany(c => c.Todos)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
