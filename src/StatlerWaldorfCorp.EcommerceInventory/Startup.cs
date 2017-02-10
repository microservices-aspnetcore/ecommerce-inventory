using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Steeltoe.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq;
using StatlerWaldorfCorp.EcommerceInventory.Persistence;

namespace StatlerWaldorfCorp.EcommerceInventory
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        
        public Startup(IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISKUStatusRepository, MemorySKUStatusRepository>();                        
        }

        public void Configure(IApplicationBuilder app)
        {
        }                       
    }
}