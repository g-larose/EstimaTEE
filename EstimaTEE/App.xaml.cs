using EstimaTEE.Data;
using EstimaTEE.Factories;
using EstimaTEE.Interfaces;
using EstimaTEE.Navigation;
using EstimaTEE.Services;
using EstimaTEE.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace EstimaTEE
{
    /// <summary>
    /// This is created by the template
    /// make changes as needed
    /// Author: Async(void)
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddSingleton<AppViewModel>();
                services.AddSingleton<INavigator, Navigator>();
                services.AddSingleton<AppDbContextFactory>();
                services.AddSingleton<MainWindow>(s => new MainWindow()
                {
                    DataContext = s.GetRequiredService<AppViewModel>()
                });

            }).Build();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();  
        }
    }
}
