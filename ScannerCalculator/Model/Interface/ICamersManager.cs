using System.Collections.Generic;

namespace ScannerCalculator.Model.Interface
{
    public interface ICamersManager
    {
        void AddCamera(Camera camera);
        void DeleteCamera(Camera camera);
        void UpdateCamera(Camera camera);
        List<Camera> GetCameras();
    }
}
