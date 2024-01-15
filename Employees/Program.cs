
using Grpc.Net.Client;
using GrpcService;
using Microsoft.AspNetCore.Hosting;

namespace Employees
{
    public class Program
    {
        // EF Core uses this method at design time to access the DbContext
        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(
                    webBuilder => webBuilder.UseStartup<StartUp>());
        public static   void Main(string[] args)
        {

            var x = new HelloRequest()
            {
                Name = "ahmed"
            };
            var channel = GrpcChannel.ForAddress("https://localhost:7292");
            var ee=new Greeter.GreeterClient(channel);
            var repl =   ee.SayHelloAsync(x);


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}