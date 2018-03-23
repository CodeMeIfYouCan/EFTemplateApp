using EFTemplateCore.ServiceLocator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Dms.DataLayer;
using Modules.Dms.DataLayer.Data.Interfaces;
using Modules.NorthWind.DataLayer;
using Modules.NorthWind.DataLayer.Data.Interfaces;
using System.IO.Compression;
using System.Linq;

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
            services.AddTransient<INorthWindTransactionalUnitOfWork, NorthWindUnitOfWork>();
            services.AddTransient<IDmsTransactionalUnitOfWork, DmsUnitOfWork>();
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "image/svg+xml" });
                //todo:turenc-->https://docs.microsoft.com/en-us/aspnet/core/performance/response-compression?tabs=aspnetcore2x
            });
            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Fastest;
            });
            DefaultServices.RegisterDefaultServices();
            //services.AddAuthorization()
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseResponseCompression();
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