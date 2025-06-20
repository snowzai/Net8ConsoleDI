using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net8ConsoleDI.Services.Interfaces;

namespace Net8ConsoleDI.Services
{
    internal sealed class ExampleTransientService : IExampleTransientService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
