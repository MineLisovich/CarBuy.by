using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;

namespace CarBuy.BLL.Interfaces
{
    public interface IModelBrandCarService
    {
        void AddModelBrandCar();
        ModelBrandCarDTO GetModelBrandCarId(int? id);
        IEnumerable<ModelBrandCarDTO> GetModelBrandCarALL();
        void Dispose();
    }
}
