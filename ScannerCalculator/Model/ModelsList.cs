using ScannerCalculator.Model.Interface;
using System;
using System.Collections.Generic;

namespace ScannerCalculator.Model
{
    //[Serializable]
    //public class CamerasList : ModelsList<Camera>
    //{

    //}
    //[Serializable]
    //public class LensesList : ModelsList<Camera>
    //{

    //}
    [Serializable]
    public class ModelsList<T> where T : IElement
    {
        public List<T> OpenedModelsList { get; set; } = new List<T>();
    }
}
