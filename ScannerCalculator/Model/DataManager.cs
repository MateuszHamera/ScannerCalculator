using ScannerCalculator.Model.Interface;
using System.IO;
using System.Xml.Serialization;

namespace ScannerCalculator.Model
{
    public class DataManager<T> : IDataManager<T> where T : IElement
    {
        private readonly string _directoryPath = @"C:\ProgramData\ScannerCalculator";
        private readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(ModelsList<T>));
        private ModelsList<T> _modelsList = new ModelsList<T>();
        public ModelsList<T> LoadDataFromFile(string path)
        {
            if (!File.Exists(path))
                return _modelsList;

            using (FileStream stream = File.OpenRead(path))
            {
                _modelsList = (ModelsList<T>)_xmlSerializer.Deserialize(stream);
            }

            return _modelsList;
        }

        public void SaveDataToFile(string path, ModelsList<T> list)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                if (!Directory.Exists(_directoryPath))
                    Directory.CreateDirectory(_directoryPath);
                
                FileStream fileStream = File.Create(path);
                fileStream.Close();
            }

            using (FileStream stream = File.OpenWrite(path))
            {
                _xmlSerializer.Serialize(stream, list);
            }
        }
    }
}
