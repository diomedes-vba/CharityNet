using CharityNet.Infrastructure.Services;
using CharityNet.UI.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace CharityNet.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            string apiKey = ConfigurationManager.AppSettings.Get("charityApiKey");

            new NonProfitService(apiKey).GetNonprofitAsync("911526803").ContinueWith((task) =>
            {
                var nonprofit = task.Result;
            });

            Window window = new MainWindow();
            window.DataContext = new MainViewModel();
            window.Show();
            
            base.OnStartup(e);
        }
    }

}
