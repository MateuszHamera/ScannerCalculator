using Prism.Commands;
using Prism.Mvvm;
using ScannerCalculator.Model;
using ScannerCalculator.Model.Interface;
using System.Linq;
using System.Windows.Input;

namespace ScannerCalculator.ViewModel
{
    public class ElementsConfigurationsViewModel:BindableBase
    {
        public ElementsConfigurationsViewModel
        (
            IElementManager<Camera> cameraManager,
            IElementManager<Lens> lensManager
        )
        {
            Title = "Added Scanner element";

            CameraManager = cameraManager;
            LensManager = lensManager;

            AddCameraCommand = new DelegateCommand(AddCamera);
            AddLensCommand = new DelegateCommand(AddLens);
        }
        public string Title { get; }

        #region Camera
        public IElementManager<Camera> CameraManager { get; set; }
        public ICommand AddCameraCommand { get; }
        public string CameraName { get; set; }
        public double MPixel { get; set; }
        public double PixelSize { get; set; }
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }

        private void AddCamera()
        {
            var lastCamera = CameraManager.GetList().OrderByDescending(x => x.Id).FirstOrDefault();
            var id = 0;
            if(lastCamera != null)
            {
                id = lastCamera.Id + 1;
            }

            Camera camera = new Camera()
            {
                Id = id,
                Name = CameraName,
                MPixel = MPixel,
                PixelSize = PixelSize,
                ResolutionHeight = ResolutionHeight,
                ResolutionWidth = ResolutionWidth
            };

            CameraManager.Add(camera);
        }
        #endregion Camera

        #region Lens
        public IElementManager<Lens> LensManager { get; set; }
        public ICommand AddLensCommand { get; }
        public string LensName { get; set; }
        public int FocalLenght { get; set; }

        private void AddLens()
        {
            var lastLens = LensManager.GetList().OrderByDescending(x => x.Id).FirstOrDefault();
            var id = 0;
            if (lastLens != null)
            {
                id = lastLens.Id + 1;
            }

            Lens lens = new Lens()
            {
                Id = id,
                Name = LensName,
                FocalLenght = FocalLenght
            };

            LensManager.Add(lens);
        }
        #endregion Lens
    }
}
