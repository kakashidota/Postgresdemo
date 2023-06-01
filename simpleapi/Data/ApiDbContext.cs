using Microsoft.EntityFrameworkCore;
using simpleapi.Models;

namespace simpleapi.Data
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
