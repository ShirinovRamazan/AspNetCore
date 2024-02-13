using Microsoft.EntityFrameworkCore;
using WebApplication2.Views.Contexts.Entities;

namespace WebApplication2.Views.Contexts
{
    public class SizeDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string cString = "Server=WIN-ESE5C65BQ0M;Database=P237;User Id=sa;Password=query;MultipleActiveResultSets=true;\r\n";
            optionsBuilder.UseSqlServer(cString);
            

            
        }

        public DbSet<Size> sizes { get; set; }
    }
}
