using GraphqlDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlDemo.DBAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Book> Books => Set<Book>();
    }
}
