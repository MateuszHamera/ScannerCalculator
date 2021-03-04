namespace ScannerCalculator.ViewModel
{
    public class ShellViewModel
    {
        public ShellViewModel
        (
            ScannerDataViewModel scannerDataViewModel,
            ScannerInformationsViewModel scannerInformationsViewModel,
            ScannerSuggestionsViewModel scannerSuggestionsViewModel,
            ElementsConfigurationsViewModel elementsConfigurationsViewModel
        )
        {
            ScannerData = scannerDataViewModel;
            ScannerInformations = scannerInformationsViewModel;
            ScannerSuggestions = scannerSuggestionsViewModel;
            ElementsConfigurations = elementsConfigurationsViewModel;
        }

        public ScannerDataViewModel ScannerData { get; }
        public ScannerInformationsViewModel ScannerInformations { get; }
        public ScannerSuggestionsViewModel ScannerSuggestions { get; }
        public ElementsConfigurationsViewModel ElementsConfigurations { get; }
    }
}
