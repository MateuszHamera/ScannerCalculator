using ScannerCalculator.Model.Interface;

namespace ScannerCalculator.Model
{
    public class Lens : IElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FocalLenght { get; set; }
        public double Fnumber { get; set; }
    }
}
