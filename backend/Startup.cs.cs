using System.Threading;
namespace backend
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Other services...
            services.AddRequestTimeouts();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Other middleware...
            app.UseRequestTimeouts();
        }

    }
}
