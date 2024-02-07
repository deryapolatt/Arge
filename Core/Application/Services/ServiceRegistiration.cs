using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public static class ServiceRegistiration // ONEMLİ 50001'DE STATİC YAPMAMIŞ OLABİLİRSİN
    {
        public static void AddApplicationServices(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(
                typeof(ServiceRegistiration).Assembly));
        }
    }
}
