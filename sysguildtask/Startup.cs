using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sysguildtask.Models;

namespace sysguildtask
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StudentContext>(opt =>
                opt.UseInMemoryDatabase("StudentList"));
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}