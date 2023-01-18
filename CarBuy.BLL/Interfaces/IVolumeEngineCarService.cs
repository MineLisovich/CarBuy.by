using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;

namespace CarBuy.BLL.Interfaces
{
    public interface IVolumeEngineCarService
    {
        void AddVolumeEngineCar();
        VolumeEngineCarDTO GetVolumeEngineCarId(int? id);
        IEnumerable<VolumeEngineCarDTO> GetVolumeEngineCarALL();
        void Dispose();
    }
}
