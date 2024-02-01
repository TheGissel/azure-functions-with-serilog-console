using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureLogging(loggingBuilder =>
    {
        loggingBuilder.AddSerilog(
            new LoggerConfiguration()
                .WriteTo
                .Console()
                .CreateLogger()
            );
    })
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    .Build();

host.Run();
