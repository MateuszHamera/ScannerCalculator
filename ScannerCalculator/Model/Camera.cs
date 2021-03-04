using ScannerCalculator.Model.Interface;

namespace ScannerCalculator.Model
{
    public class Camera : IElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MPixel { get; set; }
        public double PixelSize { get; set; }
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public double SensorWidth => (PixelSize * ResolutionWidth) / 1000;
        public double SensorHeight => (PixelSize * ResolutionHeight) / 1000;
    }
}
