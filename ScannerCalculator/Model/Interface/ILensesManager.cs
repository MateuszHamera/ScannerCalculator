using System.Collections.Generic;

namespace ScannerCalculator.Model.Interface
{
    interface ILensesManager
    {
        void AddLens(Lens lens);
        void DeleteLens(Lens lens);
        void UpdateLens(Lens lens);
        List<Lens> GetLenses();
    }
}
