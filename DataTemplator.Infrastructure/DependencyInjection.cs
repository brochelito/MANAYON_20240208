using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplator.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddTransient<IDateTimeProvider, DateTimeProvider>();
            //services.AddTransient<IEmailService, EmailService>();

            //AddPersistence(services, configuration);

            //AddAuthentication(services, configuration);

            //AddBackgroundJobs(services, configuration);

            return services;
        }
    }
}
