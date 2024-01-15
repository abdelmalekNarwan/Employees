using Employees.Entity;

namespace Employees
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
       => services.AddDbContext<EmployeeDbContext>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}
