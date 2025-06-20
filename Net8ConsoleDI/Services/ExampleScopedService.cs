using Net8ConsoleDI.Services.Interfaces;

namespace Net8ConsoleDI.Services
{
    internal sealed class ExampleScopedService : IExampleScopedService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
