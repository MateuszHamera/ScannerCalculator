namespace ScannerCalculator.ViewModel
{
    public class ShellViewModel
    {
        public ShellViewModel
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

        public ScannerDataViewModel ScannerData { get; }
        public ScannerInformationsViewModel ScannerInformations { get; }
        public ScannerSuggestionsViewModel ScannerSuggestions { get; }
    }
}
