using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;

namespace CarBuy.BLL.Interfaces
{
    public interface IBrandCarService
    {
        void AddBrandCar();
        BrandCarDTO GetBrandCarId(int? id);
        IEnumerable<BrandCarDTO> GetBrandCarsALL();
        void Dispose();
    }
}
