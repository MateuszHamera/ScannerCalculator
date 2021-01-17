using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerCalculator.ViewModel
{
    public class ScannerSuggestionsViewModel : BindableBase
    {
        public ScannerSuggestionsViewModel()
        {
            Title = "Scanner Suggestions";
            Informations = "This is specjal section. Write scanner working space and distance beetween camera or camera angle and algorythm ";
        }

        public string Title { get; }

        private string _informations;
        public string Informations
        {
            get => _informations;
            set => SetProperty(ref _informations, value);
        }

    }
}
