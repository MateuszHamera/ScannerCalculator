using ScannerCalculator.Model.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ScannerCalculator.Model
{
    public class LensesManager : IManager<Lens>
    {
        private List<Lens> Lenses { get; set; }
        public void Add(Lens lens)
        {
            var existLens = Lenses.Where(x => x.Fnumber == lens.Fnumber
                                            && x.FocalLenght == lens.FocalLenght
                                            && x.Name == x.Name)
                                    .FirstOrDefault();

            if (existLens != null)
                return;

            Lenses.Add(lens);
        }

        public void Delete(Lens lens)
        {

        }
        public void Update(Lens lens)
        {

        }

        public List<Lens> GetList() => Lenses;
    }
}
