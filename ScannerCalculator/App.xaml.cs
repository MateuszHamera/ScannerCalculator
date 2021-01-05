using Autofac;
using ScannerCalculator.Model;
using ScannerCalculator.View;
using ScannerCalculator.ViewModel;
using System.Windows;

namespace ScannerCalculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            //Register Models
            containerBuilder.RegisterType<Scanner>();
            containerBuilder.RegisterType<ScannerInformations>();
            containerBuilder.RegisterType<ScannerInformationsCalculator>();
            containerBuilder.RegisterType<ScannerSuggestions>();
            containerBuilder.RegisterType<ScannerSuggestionsCalculator>();

            //Register ViewModels
            containerBuilder.RegisterType<ScannerDataViewModel>();
            containerBuilder.RegisterType<ScannerInformationsViewModel>();
            containerBuilder.RegisterType<ScannerSuggestionsViewModel>();

            //Register Views
            containerBuilder.RegisterType<ScannerDataView>();
            containerBuilder.RegisterType<ScannerInformationsView>();
            containerBuilder.RegisterType<ScannerSuggestionsView>();

            containerBuilder.RegisterType<MainWindow>();
            containerBuilder.RegisterType<MainWindowViewModel>();

            var container = containerBuilder.Build();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
