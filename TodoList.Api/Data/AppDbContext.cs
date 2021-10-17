using Microsoft.EntityFrameworkCore;
using TodoList.Api.Models;

namespace TodoList.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        public DbSet<Plan> Plans { get; set; }
    }
}
