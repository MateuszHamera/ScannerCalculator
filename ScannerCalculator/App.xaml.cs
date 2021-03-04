using Autofac;
using ScannerCalculator.Model;
using ScannerCalculator.Model.Interface;
using ScannerCalculator.View;
using ScannerCalculator.ViewModel;
using System;
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
            containerBuilder.RegisterType<ElementsConfigurationsViewModel>();

            //Register Views
            containerBuilder.RegisterType<ScannerDataView>();
            containerBuilder.RegisterType<ScannerInformationsView>();
            containerBuilder.RegisterType<ScannerSuggestionsView>();
            containerBuilder.RegisterType<ElementsConfigurationsView>();

            RegisterInterfaces(containerBuilder);

            containerBuilder.RegisterType<Shell>();
            containerBuilder.RegisterType<ShellViewModel>();

            var container = containerBuilder.Build();
            var shell = container.Resolve<Shell>();
            shell.Show();
        }

        public void RegisterInterfaces(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterGeneric(typeof(DataManager<>)).As(typeof(IDataManager<>)).InstancePerDependency();
            containerBuilder.RegisterGeneric(typeof(ElementManager<>)).As(typeof(IElementManager<>)).InstancePerDependency();
        }
    }
}
