using Microsoft.EntityFrameworkCore;
namespace DockerApi.Models
{
    public class ApiContext : DbContext
    {
        //public ApiContext()
        //{
        //}
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
    }
}
