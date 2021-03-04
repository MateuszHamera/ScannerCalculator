using Prism.Mvvm;
using ScannerCalculator.Model;
using ScannerCalculator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace ScannerCalculator.ViewModel
{
    public class ScannerDataViewModel : BindableBase
    {
        private readonly string _camerasPath = @"C:\ProgramData\ScannerCalculator\cameras.xml";
        private readonly string _lensPath = @"C:\ProgramData\ScannerCalculator\lens.xml";
        public string Informations { get; }
        public ScannerDataViewModel
        (
            IElementManager<Camera> cameraManager,
            IElementManager<Lens> lensManager
        )
        {
            Title = "Scanner Data";
            Informations = "";

            CamerasManager = cameraManager;
            LensesManager = lensManager;

            cameraManager.LoadData(_camerasPath);
            Cameras.AddRange(cameraManager.GetList());

            lensManager.LoadData(_lensPath);
            Lenses.AddRange(lensManager.GetList());

            LeftLine = new Line()
            { X1 = 0, X2 = 0, Y1 = 0, Y2 = 0 };

            RightLine = new Line()
            { X1 = 0, X2 = 0, Y1 = 0, Y2 = 0 };

            MinValue = 150;
            MaxValue = 600;
            ActualValue = 300;
            ActualAngle = 0;

            AddData();
        }
        public IElementManager<Camera> CamerasManager { get; set; }
        public IElementManager<Lens> LensesManager { get; set; }

        private void AddData()
        {
            //Camera camera = new Camera()
            //{
            //    Id = 1,
            //    Name = "Matrix",
            //    MPixel = 12,
            //    PixelSize = 0.03,
            //    ResolutionHeight = 1000,
            //    ResolutionWidth = 2000
            //};

            //CamerasManager.Add(camera);

            //Lens lens = new Lens()
            //{
            //    Id = 1,
            //    Name = "B",
            //    FocalLenght = 35
            //};
            //LensesManager.Add(lens);
        }

        #region ScannerElementRegion
        private ObservableCollection<Camera> _cameras = new ObservableCollection<Camera>();
        public ObservableCollection<Camera> Cameras
        {
            get => _cameras;
            set => SetProperty(ref _cameras, value);
        }

        public List<Lens> Lenses { get; } 
            = new List<Lens>();

        public string SelectedCamera { get; set; }
        public string SelectedLens { get; set; }
        #endregion ScannerElementRegion


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
