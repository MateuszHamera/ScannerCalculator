using ScannerCalculator.Model.Interface;
using System.Collections.Generic;

namespace ScannerCalculator.Model
{
    public class CamersManager : IManager<Camera>
    {
        public CamersManager()
        {

        }
        private List<Camera> Cameras { get; set; }
        public void Add(Camera camera)
        {
            Cameras.Add(camera);
        }
        public void Delete(Camera camera)
        {
            Cameras.Remove(camera);
        }

        public void Update(Camera camera)
        {

        }

        public List<Camera> GetList() => Cameras;
    }
}
