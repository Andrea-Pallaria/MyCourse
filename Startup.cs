using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();     //aggiunge i servizi richiesti ad esempio: un componente Controller factory che ha lo scopo di costruire un controller
                                    //oppure il componente ControllerActionInvocher che ha lo scopo di trovare e di eseguire delle action
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routeBuilder => 
            {
                //  richiesta: /courses/detail/5   (controller,action,id)
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}" );
                //se in una richiesta mancano i frammenti allora di default usa Home, e come action usa Index, id invece è opzionale (?) cioè può anche non esserci
            });
        }
    }
}