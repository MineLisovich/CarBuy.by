using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;
using CarBuy.BLL.Infrastructure;
using CarBuy.BLL.Interfaces;
using CarBuy.DAL.Entities;
using CarBuy.DAL.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;
using System.Security.Claims;
using System.Numerics;

namespace CarBuy.BLL.Services
{
    public class FavouriteAdsService : IFavouriteAdsService
    {
        UserManager<IdentityUser> _userManager;
        public ClaimsPrincipal User { get; private set; }
        IUnitOfWork DataBase { get; set; }
        
        public FavouriteAdsService(IUnitOfWork uow, UserManager<IdentityUser> userManager)
        {
            DataBase = uow;
            _userManager = userManager;
        }
        public async void AddFavouriteAds()
        {
            AdsCarDTO adsCarDTO = new AdsCarDTO();
            ClaimsPrincipal currentUser = this.User;
            var user = await _userManager.GetUserAsync(User);
            AdsCar ads = DataBase.AdsCar.GetId(adsCarDTO.idDTO);
           
            if (ads == null) { throw new ValidationException("Объявление не найдено",""); }

            FavouritesAdsDTO favouritesAdsDTO = new FavouritesAdsDTO();

           
            FavouritesAds favouritesAds = new FavouritesAds
            {
                AdsCarid = adsCarDTO.idDTO, 
                UserId = user.Id
            };
            DataBase.FavouritesAds.SaveItem(favouritesAds);
            DataBase.Save();
        }
        public IEnumerable<FavouritesAdsDTO> GetFavouriteAdsALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FavouritesAds, FavouritesAdsDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<FavouritesAds>, List<FavouritesAdsDTO>>(DataBase.FavouritesAds.GetAll());
        }
        public FavouritesAdsDTO GetFavouriteAdsId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id объявления автомобиля", "");
            }
            var favourite = DataBase.FavouritesAds.GetId(id.Value);
            if (favourite == null) { throw new ValidationException("не найдено", ""); }

            return new FavouritesAdsDTO
            {
                idDTO = favourite.id,
                AdsCaridDTO = favourite.AdsCarid,
                UserIdDTO = favourite.UserId

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
