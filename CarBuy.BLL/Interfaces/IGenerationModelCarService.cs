using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;
namespace CarBuy.BLL.Interfaces
{
    public interface IGenerationModelCarService
    {
        void AddGenerationModelCar();
        GenerationModelCarDTO GetGenerationModelCarId(int? id);
        IEnumerable<GenerationModelCarDTO> GetGenerationModelCarALL();
        void Dispose();
    }
}
