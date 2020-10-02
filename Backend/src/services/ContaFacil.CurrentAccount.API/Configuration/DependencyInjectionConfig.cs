using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ContaFacil.CurrentAccount.Domain;
using ContaFacil.CurrentAccount.Data;
using ContaFacil.CurrentAccount.Data.Repository;
using ContaFacil.WebAPI.Core.User;

namespace ContaFacil.CurrentAccount.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, IAspNetUser>();

            //Services
            services.AddScoped<ICurrentAccountService, CurrentAccountService>();

            // Data
            services.AddScoped<ICurrentAccountRepository, CurrentAccountRepository>();
            services.AddScoped<CurrentAccountContext>();
        }
    }
}