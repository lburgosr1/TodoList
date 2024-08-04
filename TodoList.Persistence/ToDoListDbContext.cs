using Microsoft.EntityFrameworkCore;
using TodoList.Core.Entities;

namespace ToDoList.Persistence
{
    public class ToDoListDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoTask> Tasks { get; set; }
        public ToDoListDbContext(DbContextOptions options) : base(options) { }
    }
}
