using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;


namespace CarBuy.BLL.Interfaces
{
    public interface IAdsCarService
    {
        void  MakeAdsCar();
        AdsCarDTO GetAdsCarID(int? id);
        IEnumerable<AdsCarDTO> GetAdsCarsALL();
        void Dispose();

    }
}
