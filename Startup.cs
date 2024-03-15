using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
//using BlazorAppDemo.Data;
using BlazorAppDemo.Components;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

using System.Text;
using Microsoft.Extensions.DependencyInjection;
using BlazorAppDemo.Services;
//using BlazorAppDemo.Services;

namespace BlazorAppDemo
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlazorDemoDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Add services for Razor Components and Interactive Server Components
            services.AddRazorComponents()
                    .AddInteractiveServerComponents();

            services.AddSingleton<ProductService>();

        }
    }
}


// Register DbContext and related services
/*builder.Services.AddDbContext<BlazorDemoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.EnableDetailedErrors(true); // Enable detailed error messages (optional)
});*/