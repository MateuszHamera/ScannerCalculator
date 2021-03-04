using System.Collections.Generic;

namespace ScannerCalculator.Model.Interface
{
    public interface IElementManager<T> where T : IElement
    {
        List<T> GetList();
        void LoadData(string path);
        void Add(T element);
        void Delete(T element);
        void Update(T element);
    }
}
