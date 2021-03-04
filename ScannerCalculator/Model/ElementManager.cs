using ScannerCalculator.Model.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ScannerCalculator.Model
{
    public class ElementManager<T> : IElementManager<T> where T : IElement
    {
        private readonly IDataManager<T> _dataManager;
        public ElementManager(
            IDataManager<T> dataManager)
        {
            _dataManager = dataManager;
        }
        private ObservableCollection<T> Elements { get; set; }
        = new ObservableCollection<T>();
        public List<T> GetList() => Elements.ToList();
        public string Path { get; set; }
        public void LoadData(string path)
        {
            if (string.IsNullOrEmpty(path))
                return;

            Path = path;
            var data = _dataManager.LoadDataFromFile(path);

            if (data.OpenedModelsList.Count == 0)
                return;

            Elements.Clear();
            Elements.AddRange(data.OpenedModelsList);
        }
        public void Add(T element)
        {
            Elements.Add(element);

            ModelsList<T> modelsList = new ModelsList<T>();
            modelsList.OpenedModelsList.AddRange(Elements);

            _dataManager.SaveDataToFile(Path, modelsList);
        }

        public void Delete(T element)
        {
            Elements.Remove(element);

            ModelsList<T> modelsList = new ModelsList<T>();
            modelsList.OpenedModelsList.AddRange(Elements);

            _dataManager.SaveDataToFile(Path, modelsList);
        }

        public void Update(T element)
        {
            var ele = Elements
                .FirstOrDefault(
                x => x.Id == element.Id 
                && x.Name == element.Name);

            if(ele != null)
            {
                Elements.Remove(ele);
            }

            Elements.Add(element);

            ModelsList<T> modelsList = new ModelsList<T>();
            modelsList.OpenedModelsList.AddRange(Elements);

            _dataManager.SaveDataToFile(Path, modelsList);
        }
    }
}
