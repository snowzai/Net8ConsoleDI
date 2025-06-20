using Net8ConsoleDI.Services.Interfaces;

namespace Net8ConsoleDI.Services
{
    internal sealed class ExampleSingletonService : IExampleSingletonService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
