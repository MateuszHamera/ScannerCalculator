using ScannerCalculator.Model.Interface;
using System.Collections.Generic;

namespace ScannerCalculator.Model
{
    public class CamersManager : ICamersManager
    {
        public CamersManager()
        {

        }
        private List<Camera> Cameras { get; set; }
        public void AddCamera(Camera camera)
        {

        }
        public void DeleteCamera(Camera camera)
        {

        }

        public void UpdateCamera(Camera camera)
        {

        }

        public List<Camera> GetCameras()
        {
            return Cameras;
        }
    }
}
