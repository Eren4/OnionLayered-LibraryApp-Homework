using Onion.WebApi.MapperResolvers;
using Onion.Application.DependencyResolvers;
using Onion.InnerInfrastructure.DependencyResolvers;
using Onion.Persistence.DependencyResolvers;

namespace Onion.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContextService();
            builder.Services.AddRepositoryService();
            builder.Services.AddManagerService();
            builder.Services.AddDTOMapperService();
            builder.Services.AddVmMapperService();

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
