using Microsoft.Extensions.DependencyInjection;

namespace Net8ConsoleDI.Services.Interfaces
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }

        ServiceLifetime Lifetime { get; }
    }
}
