using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ContaFacil.CurrentAccount.Domain;
using ContaFacil.CurrentAccount.Data;
using ContaFacil.CurrentAccount.Data.Repository;

namespace ContaFacil.CurrentAccount.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();


            // Data
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<PedidosContext>();
        }
    }
}