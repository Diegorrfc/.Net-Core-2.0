using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aulaDotNetCore.Areas.Pais.Models;
using aulaDotNetCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace aulaDotNetCore
{
    public class Startup
    {
      
        private IHttpContextAccessor HttpContextAccessor { get; set; }
        public Startup( IConfiguration configuration)
        {
            
            this.Configuration = configuration;

        }
       

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

           services.AddMvc();
           services.AddTransient<ListaEstadoServices>();
           services.AddTransient<ProdutosServices>();
           services.AddDbContext<AplicacaoContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                //routes.MapAreaRoute("areaRoute", "Admin", "Admin/Index/{id?}");
                routes.MapRoute("areaRoute", "{area:exists}/{Controller=Admin}/{Action=Index}/{id?}");
                
                routes.MapRoute(
                    name: "default",
                                                         
                    template: "{controller=Home}/{action=About}/{id?}"); 
            }); 
        }
    }
}
