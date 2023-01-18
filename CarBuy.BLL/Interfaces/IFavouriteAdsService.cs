using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;
namespace CarBuy.BLL.Interfaces
{
    public interface IFavouriteAdsService
    {
        void AddFavouriteAds();
        FavouritesAdsDTO GetFavouriteAdsId(int? id);
        IEnumerable<FavouritesAdsDTO> GetFavouriteAdsALL();
        void Dispose();
    }
}
