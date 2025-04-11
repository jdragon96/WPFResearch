using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Reseach.Service;
using Research.Page.Dashboard;
using Research.Page.Main;
using System.Windows;

namespace Research.Page.Main
{
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<INavService, NavService>();
                    services.AddSingleton<MainWindow>(provider => new MainWindow
                    {
                        DataContext = provider.GetRequiredService<MainWindowVM>()
                    });
                    services.AddSingleton<MainWindowVM>();
                    services.AddSingleton<DashboardView>(provider => new DashboardView
                    {
                        DataContext = provider.GetRequiredService<DashboardVM>()
                    });
                    services.AddSingleton<DashboardVM>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            base.OnExit(e);
        }
    }
}
