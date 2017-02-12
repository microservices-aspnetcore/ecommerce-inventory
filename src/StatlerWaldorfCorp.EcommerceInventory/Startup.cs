using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;
using System.Linq;
using StatlerWaldorfCorp.EcommerceInventory.Persistence;
using Steeltoe.Discovery.Client;

namespace StatlerWaldorfCorp.EcommerceInventory
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        
        private ILogger logger;
        private ILoggerFactory loggerFactory;

        public Startup(IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            var builder = new ConfigurationBuilder()
                // Remove AddJsonFile later
                .SetBasePath(System.IO.Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();            


            this.loggerFactory = loggerFactory;
            this.loggerFactory.AddConsole(LogLevel.Information);
            this.loggerFactory.AddDebug();

            this.logger = this.loggerFactory.CreateLogger("Startup");            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDiscoveryClient(Configuration);            
            services.AddScoped<ISKUStatusRepository, MemorySKUStatusRepository>();                        
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDiscoveryClient();            
            app.UseMvc();            
        }                       
    }
}