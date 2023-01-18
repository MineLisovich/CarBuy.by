using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;

namespace CarBuy.BLL.Interfaces
{
    public interface IBodyCarService
    {
        void AddBodyCar();
        BodyCarDTO GetBodyCarID(int? id);
        IEnumerable<BodyCarDTO> GetBodyALL();
        void Dispose();
    }
}
