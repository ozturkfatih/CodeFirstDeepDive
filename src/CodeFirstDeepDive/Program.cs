using System.IO;
using CodeFirstDeepDive.Data;
using CodeFirstDeepDive.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CodeFirstDeepDive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create service collection
            var collection = new ServiceCollection();
            ConfigureServices(collection);
            // create service provider
            var provider = collection.BuildServiceProvider();
            // entry to run app
            provider.GetService<AppRun>().Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // add logging
            services.AddSingleton(new LoggerFactory().AddConsole().AddDebug());
            services.AddLogging();
            // build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();
            services.AddOptions();
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("AppDbContext"))
            );
            // add services
            services.AddTransient<ILogService, LogService>();
            // add app
            services.AddTransient<AppRun>();
        }
    }
}
