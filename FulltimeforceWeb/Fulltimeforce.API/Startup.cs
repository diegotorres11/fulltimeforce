using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fulltimeforce.API.Abstract;
using Fulltimeforce.API.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fulltimeforce.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connectionString = @"Server=(localdb)\mssqllocaldb; Database=Grades; Trusted_Connection=true";
            services.AddDbContext<GradeContext>(builder => builder.UseSqlServer(connectionString));
            services.AddScoped<IGradeRepository, DbGradeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}
