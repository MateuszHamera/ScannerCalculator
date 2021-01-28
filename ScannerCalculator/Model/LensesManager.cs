using ScannerCalculator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerCalculator.Model
{
    public class LensesManager : ILensesManager
    {
        private List<Lens> Lenses { get; set; }
        public void AddLens(Lens lens)
        {
            var existLens = Lenses.Where(x => x.Fnumber == lens.Fnumber
                                            && x.FocalLenght == lens.FocalLenght
                                            && x.Name == x.Name)
                                    .FirstOrDefault();

            if (existLens != null)
                return;

            Lenses.Add(lens);
        }

        public void DeleteLens(Lens lens)
        {

        }

        public List<Lens> GetLenses()
        {
            return Lenses;
        }

        public void UpdateLens(Lens lens)
        {

        }
    }
}
