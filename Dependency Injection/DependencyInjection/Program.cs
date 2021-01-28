using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{

    class Program
    {

        public void ConfigureServices(IServiceCollection services) {

            //we are adding the IMydependency interface to the mydependency class as a service
            services.AddScoped<IMyDependency, MyDependency>();

            //******Away investigating Razor Pages first**** Return here
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0
            //services.addRazorPages();
        }

        static void Main(string[] args)
        {

            var test = new IndexModel();
            test.OnGet();

        }
    }
}
