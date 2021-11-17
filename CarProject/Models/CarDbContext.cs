using System;
using System.Data.Entity;
using System.Linq;

namespace CarProject.Models
{
    public class CarDbContext : DbContext
    {
        public CarDbContext()
            : base("name=CarDbContext")
        {
        }
        public DbSet<CarModel> Cars { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
    }
}