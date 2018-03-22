using EFTemplateCore.ServiceLocator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Modules.NorthWind.Data;
using Modules.NorthWind.Data.Interfaces;

namespace EFTemplateApp
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
            services.AddMvc();
            services.AddTransient<INorthWindTransactionaUnitOfWork, NorthWindUnitOfWork>();
            DefaultServices.RegisterDefaultServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
        ////todo:check if adding logging method into loggerFactory
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //{
        //    loggerFactory.AddLog4Net(); // << Add this line
        //    app.UseMvc();
        //}
    }
}