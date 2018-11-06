using DockerApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace DockerApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            // services.AddMvc();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));


            var hostname = Environment.GetEnvironmentVariable("SQLSERVER_HOST") ?? "localhost";
            var password = Environment.GetEnvironmentVariable("SA_PASSWORD") ?? "Ajeesh250282";
            var connString = $"Server={hostname};Database=DockerTestDb;User=sa;Password={password};";
           // var connString = Configuration.GetConnectionString("DefaultConnection");
            //SqlConnection con = new SqlConnection(connString);
            //con.Open(); 

            services.AddDbContext<ApiContext>(options => options.UseSqlServer(connString));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //var cnx = new SqlConnection(Configuration.GetConnectionString("DefaultConnection"));
                //var evolve = new Evolve.Evolve(cnx)
                //{
                //    Locations = new List<string> { @"flyway\sql" },
                //    IsEraseDisabled = true,
                //    Driver= "SqlClient",
                //};
                //evolve.Migrate();
            }

            app.UseCors("MyPolicy");
            app.UseMvc();
        }
    }
}
