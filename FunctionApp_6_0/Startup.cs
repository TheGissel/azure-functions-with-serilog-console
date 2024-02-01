using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

[assembly: FunctionsStartup(typeof(FunctionApp_6_0.Startup))]

namespace FunctionApp_6_0;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSerilog(
                new LoggerConfiguration()
                    .WriteTo
                    .Console()
                    .CreateLogger()
                );
        });
    }
}