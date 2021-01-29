using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerCalculator.ViewModel
{
    public class ScannerDataViewModel : BindableBase
    {
        public ScannerDataViewModel()
        {
            Title = "Scanner Data";
            MinValue = 150;
            MaxValue = 600;
            ActualValue = 300;
            ActualAngle = 15;
        }

        public string Title { get; }
        public int MinValue { get; }
        private int _actulaValue;
        public int ActualValue
        {
            get => _actulaValue;
            set => SetProperty(ref _actulaValue, value);
        }
        public int MaxValue { get; }

        private int _actualAngle;
        public int ActualAngle
        {
            get => _actualAngle;
            set => SetProperty(ref _actualAngle, value);
        }

    }
}
