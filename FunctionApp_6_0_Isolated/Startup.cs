using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;

[assembly: FunctionsStartup(typeof(FunctionApp_6_0_Isolated.Startup))]

namespace FunctionApp_6_0_Isolated;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSerilog(
                new LoggerConfiguration()
                    .MinimumLevel.Override("Microsoft.Azure.WebJobs.Hosting", LogEventLevel.Warning)
                    .WriteTo
                    .Console(
                            outputTemplate:
                            "{Timestamp:HH:mm:ss.fff} [{Level:u3}] {SourceContext:j} {Message:lj}{NewLine}{Exception}"
                    )
                    .CreateLogger());
        });
    }
}