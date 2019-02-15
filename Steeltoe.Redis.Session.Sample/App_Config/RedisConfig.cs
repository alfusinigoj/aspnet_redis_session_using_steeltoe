using Microsoft.Web.Redis;
using StackExchange.Redis;
using System;

namespace Steeltoe.Redis.Session.Sample
{
    public class RedisConfig
    {
        static IConnectionMultiplexer connectionMultiplexer;

        //Just to protect the reference to Microsoft.Web.RedisSessionStateProvider (avoid accidental removal)
        static RedisSessionStateProvider redisSessionStateProvider;

        static RedisConfig()
        {
            connectionMultiplexer = ServerConfig.GetService<IConnectionMultiplexer>() 
                ?? throw new ArgumentNullException(nameof(IConnectionMultiplexer));
        }
        
        public static string GetConnectionString()
        {
            return connectionMultiplexer.Configuration;
        }
    }
}