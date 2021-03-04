namespace ScannerCalculator.Model.Interface
{
    public interface IDataManager<T> where T : IElement
    {
        ModelsList<T> LoadDataFromFile(string path);
        void SaveDataToFile(string path, ModelsList<T> list);
    }
}
