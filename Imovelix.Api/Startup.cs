using Imovelix.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Imovelix.Api
{ 
        public class Startup
        {

            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            public void ConfigurationService(IServiceCollection services)
            {
            services.AddDbContext<DataContext>(
                context => context.UseSqlite(Configuration.GetConnectionString("WebApiDatabase")));
                 
             services.AddControllers();
                services.AddEndpointsApiExplorer();
                services.AddSwaggerGen();

             services.AddCors();

        }

            public void Configure(WebApplication app, IWebHostEnvironment environment)
            {
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();

                app.UseCors(option => option.AllowAnyHeader()
                                   .AllowAnyMethod()
                                   .AllowAnyOrigin());

            app.MapControllers();
            }
        }
    

}

