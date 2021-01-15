using ScannerCalculator.ViewModel;
using System.Windows;

namespace ScannerCalculator.View
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell(ShellViewModel shellViewModel)
        {
            InitializeComponent();
            DataContext = shellViewModel;
        }
    }
}
