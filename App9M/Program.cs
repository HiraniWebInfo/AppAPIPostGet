using App9M.Data;
using App9M.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App9M
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", false, true);

            Configuration = builder.Build();

            //var optionBuilder = new DbContextOptionsBuilder<DataContext>()
            //    .UseSqlite(Configuration.GetConnectionString("DefaultConnection"));

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<frmMain9M>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Configuration { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddDbContextPool<DataContext>(options => 
                        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
                    services.AddTransient<iDataService, DataService>();

                    services.AddTransient<frmMain9M>();
                    services.AddTransient<frmBaseUrl>();
                    services.AddTransient<frmLoginAPI>();
                    services.AddTransient<frmSetHeaders>();
                });
        }
    }
}