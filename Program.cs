using GamingWebsiteBE.Data;
using GamingWebsiteBE.Debug;
using Microsoft.EntityFrameworkCore;

namespace GamingWebsiteBE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Allow API access to the front-end only
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("SpecificOrigin", policy =>
                {
                    policy.WithOrigins("http://localhost:4200").AllowAnyMethod()
                                                               .AllowAnyHeader();
                });
            });

            // Configure the database context to use SQL Server
            builder.Services.AddDbContext<GamingDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GamingDb")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Enable CORS
            app.UseCors("SpecificOrigin");
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            // Create the database and seed it
            using (var scope = app.Services.CreateScope())  // Creates a new scope, necessary for accessing scoped services like DbContext
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<GamingDbContext>();

                //DatabaseSeeder.SeedDatabase(dbContext);    // Call the DatabaseSeeder
                //DatabaseUpdater.UpdateDatabase(dbContext);   // Call the DatabaseUpdated

                // Used to test queries, find better alternative
                /*
                var queryManager = new RunQueries(dbContext);
                queryManager.ExecuteGamePrices(2);            // Needs a gameId (max 55)
                queryManager.ExecuteAllGames();
                queryManager.ExecuteGetStore("gog");          // Needs a store name (string)
                */
            }

                app.Run();
        }
    }
}
