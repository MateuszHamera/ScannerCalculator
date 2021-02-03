using System.Collections.Generic;

namespace ScannerCalculator.Model.Interface
{
    public interface IManager<T>
    {
        void Add(T element);
        void Delete(T element);
        void Update(T element);
        List<T> GetList();
    }
}
