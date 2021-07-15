using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Seccion_17_EFC.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seccion_17_EFC.Services;

namespace Seccion_17_EFC
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
            services.AddTransient<IContextoDB, ContextoDB>();
            services.AddTransient<ICancionService, CancionService>();
            services.AddTransient<IAlbumService, AlbumService>();
            services.AddTransient<IAutorService, AutorService>();

            services.AddDbContext<ContextoDB>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                { 
                    Title = "Seccion_17_EFC", 
                    Version = "v1",
                    Description = "Ejemplo de .NET",
                    TermsOfService = new Uri("https://google.com"),
                    Contact=new OpenApiContact 
                    {
                        Name="Nicolas Díaz",
                        Email="nicolas.diaz@teaminternational.com",
                        Url=new Uri("https://udemy.com")
                    },
                    License=new OpenApiLicense
                    {
                        Name="Licence number 00000",
                        Url=new Uri("https://twitter.com")
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Seccion_17_EFC v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
