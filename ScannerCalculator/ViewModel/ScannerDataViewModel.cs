using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace ScannerCalculator.ViewModel
{
    public class ScannerDataViewModel : BindableBase
    {
        public ScannerDataViewModel()
        {
            Title = "Scanner Data";

            LeftLine = new Line()
            { X1 = 0, X2 = 0, Y1 = 0, Y2 = 0 };

            RightLine = new Line()
            { X1 = 0, X2 = 0, Y1 = 0, Y2 = 0 };

            MinValue = 150;
            MaxValue = 600;
            ActualValue = 300;
            ActualAngle = 10;


        }

        public string Title { get; }
        public int MinValue { get; }
        public int MaxValue { get; }

        private int _actulaValue;
        public int ActualValue
        {
            get => _actulaValue;
            set => SetProperty(ref _actulaValue, value, ActualValueChanged);
        }
        private void ActualValueChanged()
        {
            LeftLine.X1 = ActualValue;
            LeftLine.X2 = ActualValue;
            LeftLine.Y1 = 0;
            LeftLine.Y2 = 200;

            RightLine.X1 = ActualValue - 125;
            RightLine.X2 = ActualValue - 125;
            RightLine.Y1 = 0;
            RightLine.Y2 = 200;
        }

        private int _actualAngle;
        public int ActualAngle
        {
            get => _actualAngle;
            set => SetProperty(ref _actualAngle, value, ActualAngleChanged);
        }

        private void ActualAngleChanged()
        {

        }


        private Line _leftline;
        public Line LeftLine
        {
            get => _leftline;
            set => SetProperty(ref _leftline, value);
        }
        private Line _rightline;
        public Line RightLine
        {
            get => _rightline;
            set => SetProperty(ref _rightline, value);
        }
    }
}
