using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}