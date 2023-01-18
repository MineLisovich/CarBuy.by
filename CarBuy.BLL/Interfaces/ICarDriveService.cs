using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;

namespace CarBuy.BLL.Interfaces
{
    public interface ICarDriveService
    {
        void AddCarDrive();
        CarDriveDTO GetCarDriveId(int? id);
        IEnumerable<CarDriveDTO> GetCarDriveALL();
        void Dispose();
    }
}
