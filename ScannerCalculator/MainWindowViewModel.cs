using ScannerCalculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerCalculator
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel
        (
            ScannerDataViewModel scannerDataViewModel,
            ScannerInformationsViewModel scannerInformationsViewModel,
            ScannerSuggestionsViewModel scannerSuggestionsViewModel
        )
        {
            ScannerData = scannerDataViewModel;
            ScannerInformations = scannerInformationsViewModel;
            ScannerSuggestions = scannerSuggestionsViewModel;
        }

        public ScannerDataViewModel ScannerData { get;}
        public ScannerInformationsViewModel ScannerInformations { get; }
        public ScannerSuggestionsViewModel  ScannerSuggestions{ get; }
    }
}