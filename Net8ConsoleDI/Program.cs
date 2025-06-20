using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Net8ConsoleDI.Services;
using Net8ConsoleDI.Services.Interfaces;

Console.WriteLine("Hello, World!");


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
builder.Services.AddTransient<ServiceLifetimeReporter>();

using IHost host = builder.Build();

DIExemplifyServiceLifeTime.ExemplifyServiceLifetime(host.Services, "Lifetime 1");
DIExemplifyServiceLifeTime.ExemplifyServiceLifetime(host.Services, "Lifetime 2");

await host.RunAsync();