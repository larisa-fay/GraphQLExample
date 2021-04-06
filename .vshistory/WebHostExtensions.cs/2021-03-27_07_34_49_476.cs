using System;
using AFL.OTDR.Server.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AFL.OTDR.Server
{
    /// <summary>
    /// Performs initial steps after startup is completed and before running the host
    /// </summary>
    public static class WebHostExtensions
    {
        public static IHost OTDRServiceInit(this IHost host)
        {
            using (IServiceScope scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;

                OTDRDbInitializer.Initialize(services);
                ProjectDbInitializer.Initialize(services);
            }

            return host;
        }
    }
}
