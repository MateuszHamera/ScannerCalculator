namespace ScannerCalculator.Model
{
    public class Camera
    {
        public string Name { get; }
        public double MPixel { get; }
        public double PixelSize { get; }
        public int ResolutionWidth { get; }
        public int ResolutionHeight { get; }
        public double SensorWidth => (PixelSize * ResolutionWidth) / 1000;
        public double SensorHeight => (PixelSize * ResolutionHeight) / 1000;
    }
}
