using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Emr.Database;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Emr.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args)
                .UpdateDatabase<DatabaseContext>()
                .SetUp<InitializerDb>(x=>x.CreateRoles())
                .Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }

    public static class ExtensionWebHost
    {
        /// <summary>
        /// Накатывает миграции
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="host"></param>
        /// <returns></returns>
        public static IWebHost UpdateDatabase<T>(this IWebHost host) where T : DbContext
        {
            var db = host.Services.CreateScope().ServiceProvider.GetService<T>();
            db?.Database.Migrate();
            return host;
        }

        public static IWebHost SetUp<T>(this IWebHost host, Action<T> action) where T:class
        {
            var service = host.Services.CreateScope().ServiceProvider.GetRequiredService<T>();
            action(service);
            return host;
        }
    }
}
