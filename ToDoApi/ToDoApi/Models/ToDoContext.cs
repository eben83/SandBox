using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        { }
        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}