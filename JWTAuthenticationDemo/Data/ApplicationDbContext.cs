using JWTAuthenticationDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthenticationDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
