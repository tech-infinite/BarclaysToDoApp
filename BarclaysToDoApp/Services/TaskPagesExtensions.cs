using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;


namespace BarclaysToDoApp.Services
{
    public static class TaskPagesExtensions
    {
        public static void ConfigureAuthorizationOptions(this IServiceCollection services)
        {
            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizePage("/SecurePage");
            });
        }
    }
}
