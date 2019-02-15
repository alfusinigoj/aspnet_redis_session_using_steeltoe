using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Steeltoe.CloudFoundry.Connector.Redis;

namespace Steeltoe.Redis.Session.Sample
{
    public class ServerConfig
    {
        static IHost host;
        public static void Register(string environment)
        {
            host = new HostBuilder()
                .ConfigureAppConfiguration((builderContext, configBuilder) =>
                {
                    configBuilder.AddJsonFile("appSettings.json", false, false);
                    configBuilder.AddJsonFile($"appsettings.{environment}.json", optional: true);
                    configBuilder.AddEnvironmentVariables();
                })
                .ConfigureServices((builderContext, services) =>
                {
                    services.AddRedisConnectionMultiplexer(builderContext.Configuration);
                })
                .Build();
        }
        public static T GetService<T>()
        {
            return host.Services.GetService<T>();
        }
    }
}