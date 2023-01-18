using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;
namespace CarBuy.BLL.Interfaces
{
    public interface IEngineCarService
    {
        void AddEngineCar();
        EngineCarDTO GetEngineCarId(int? id);
        IEnumerable<EngineCarDTO> GetEngineALL();
        void Dispose();
    }
}
