using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerCalculator.ViewModel
{
    public class ScannerInformationsViewModel
    {
        public ScannerInformationsViewModel()
        {
            Title = "Scanner Informations";
            Informations = "Info";
        }
        public string Title { get; }
        public string Informations { get; }
    }
}
