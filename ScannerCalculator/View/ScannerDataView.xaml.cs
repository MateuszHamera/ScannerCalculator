using ScannerCalculator.Model;
using System.Collections.Generic;
using System.Windows.Controls;

namespace ScannerCalculator.View
{
    /// <summary>
    /// Interaction logic for ScannerDataView.xaml
    /// </summary>
    public partial class ScannerDataView : UserControl
    {
        public ScannerDataView()
        {
            InitializeComponent();

            List<Camera> cameras = new List<Camera>();

            Camera camera = new Camera()
            {
                Id = 1,
                Name = "Matrix",
                MPixel = 12,
                PixelSize = 0.03,
                ResolutionHeight = 1000,
                ResolutionWidth = 2000
            };

            cameras.Add(camera);

            dataGrid.ItemsSource = cameras;
        }
    }
}
