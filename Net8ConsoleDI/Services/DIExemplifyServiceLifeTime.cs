using Microsoft.Extensions.DependencyInjection;

namespace Net8ConsoleDI.Services
{
    public static class DIExemplifyServiceLifeTime
    {
        public static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
            logger.ReportServiceLifetimeDetails(
                $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            Console.WriteLine("...");

            logger = provider.GetRequiredService<ServiceLifetimeReporter>();
            logger.ReportServiceLifetimeDetails(
                $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            Console.WriteLine("...");
        }
    }
}
