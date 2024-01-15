using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Employees.Entity
{
    public class EmployeeDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options, IConfiguration configuration)
         : base(options)
        {
            _configuration = configuration;

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
