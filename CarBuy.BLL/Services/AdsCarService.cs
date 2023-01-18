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
    public class AdsCarService : IAdsCarService
    {
        UserManager<IdentityUser> _userManager;
        IUnitOfWork DataBase { get; set; }
        public ClaimsPrincipal User { get; private set; }

        public AdsCarService (IUnitOfWork uow, UserManager<IdentityUser> userManager)
        {
            DataBase = uow;
            _userManager = userManager;
        }
        public async void MakeAdsCar()
        {
            AdsCarDTO adsCarDTO = new AdsCarDTO();
            BrandCarDTO brandCarDTO = new BrandCarDTO();
            GearShiftBoxDTO gearShiftBoxDTO = new GearShiftBoxDTO();
            EngineCarDTO engineCarDTO = new EngineCarDTO();
            CarDriveDTO carDriveDTO = new CarDriveDTO();
            VolumeEngineCarDTO volumeEngineCarDTO = new VolumeEngineCarDTO();  
            ModelBrandCarDTO modelBrandCarDTO = new ModelBrandCarDTO();
            GenerationModelCarDTO generationModelCarDTO = new GenerationModelCarDTO();

            BrandCar brandCar = DataBase.BrandCar.GetId(brandCarDTO.idDTO);
            GearShiftBox gearShiftBox = DataBase.GearShiftBox.GetId(gearShiftBoxDTO.idDTO);
            EngineCar engineCar = DataBase.EngineCar.GetId(engineCarDTO.idDTO);
            CarDrive carDrive = DataBase.CarDrive.GetId(carDriveDTO.idDTO); 
            VolumeEngineCar volumeEngineCar = DataBase.VolumeEngineCar.GetId(volumeEngineCarDTO.idDTO);
            ModelBrandCar modelBrandCar = DataBase.ModelBrandCar.GetId(modelBrandCarDTO.idDTO);
            GenerationModelCar generationModelCar = DataBase.GenerationModelCar.GetId(generationModelCarDTO.idDTO);
            
            ClaimsPrincipal currentUser = this.User;
            var user = await _userManager.GetUserAsync(User);

            // Валидация
            if (brandCar == null) {throw new ValidationException("Выберите марку автомобиля", "");}
            if (modelBrandCar == null) { throw new ValidationException("Выберите модель автомобиля",""); }
            if (generationModelCar == null) { throw new ValidationException("Выберите поколение автомобиля",""); }
            if (gearShiftBox == null) { throw new ValidationException("Выберите коробку передач", ""); }
            if (engineCar == null) { throw new ValidationException("Выберите тип двигателя", ""); }
            if (carDrive == null) { throw new ValidationException("Выберите привод автомобиля",""); }
            if (volumeEngineCar == null) { throw new ValidationException("Выберите объём двигателя", ""); }
            if (user == null) { return; }
            AdsCar adsCar = new AdsCar 
            { 
                Mileage = adsCarDTO.MileageDTO,
                Color = adsCarDTO.ColorDTO,
                VIN = adsCarDTO.VINDTO,
                Price = adsCarDTO.PriceDTO,
                SellersComment = adsCarDTO.SellersCommentDTO,
                PastOwners = adsCarDTO.PastOwnersDTO,
                Horsepower = adsCarDTO.HorsepowerDTO,
                PassportCar = adsCarDTO.PassportCarDTO,
                Multimedia = adsCarDTO.MultimediaDTO,
                Safety = adsCarDTO.SafetyDTO,
                ExteriorElements = adsCarDTO.ExteriorElementsDTO,
                Rudder = adsCarDTO.RudderDTO,   
                Condition = adsCarDTO.ConditionDTO, 
                Customs = adsCarDTO.CustomsDTO,
                Ownership = adsCarDTO.OwnershipDTO,
                ModelCarAds = modelBrandCar.NameModelBrand,
                GenerationModelAds = generationModelCar.NameGenerationModel,
                PhotoCar_1 = adsCarDTO.PhotoCar_1DTO,
                PhotoCar_2 = adsCarDTO.PhotoCar_2DTO,
                PhotoCar_3 = adsCarDTO.PhotoCar_3DTO,
                PhotoCar_4 = adsCarDTO.PhotoCar_4DTO,
                PhotoCar_5 = adsCarDTO.PhotoCar_5DTO,
                BrandCarid = brandCar.id,
                GearShiftBoxid = gearShiftBox.id,
                EngineCarid = engineCar.id,
                CarDriveid = carDrive.id,
                VolumeEngineCarid = volumeEngineCar.id,
                UserId = user.Id,

                AddDateAds = DateTime.Now,
                VisibleAds = false,
                PassedModeration = false
            };
            DataBase.AdsCar.SaveItem(adsCar);
            DataBase.Save();
        }
        public IEnumerable<AdsCarDTO> GetAdsCarsALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration (cfg=> cfg.CreateMap<AdsCar,AdsCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<AdsCar>, List<AdsCarDTO>>(DataBase.AdsCar.GetAll());
        }

        public AdsCarDTO GetAdsCarID(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id Объявления", "");
            }
            var ads = DataBase.AdsCar.GetId(id.Value);
            if (ads == null) { throw new ValidationException("Объявление не найдено",""); }

            return new AdsCarDTO { 
                idDTO = ads.id,
                MileageDTO = ads.Mileage,
                ColorDTO = ads.Color,
                VINDTO = ads.VIN,
                PriceDTO = ads.Price,
                SellersCommentDTO = ads.SellersComment,
                PastOwnersDTO = ads.PastOwners,
                HorsepowerDTO = ads.Horsepower,
                PassportCarDTO = ads.PassportCar,
                MultimediaDTO = ads.Multimedia,
                SafetyDTO = ads.Safety,
                ExteriorElementsDTO = ads.ExteriorElements,
                RudderDTO = ads.Rudder,
                ConditionDTO = ads.Condition,
                CustomsDTO = ads.Customs,
                OwnershipDTO = ads.Ownership,
                ModelCarAdsDTO = ads.ModelCarAds,
                GenerationModelAdsDTO = ads.GenerationModelAds,
                PhotoCar_1DTO = ads.PhotoCar_1,
                PhotoCar_2DTO = ads.PhotoCar_2,
                PhotoCar_3DTO = ads.PhotoCar_3, 
                PhotoCar_4DTO = ads.PhotoCar_4, 
                PhotoCar_5DTO = ads.PhotoCar_5,
                BodyCaridDTO = ads.BodyCarid,
                BrandCaridDTO = ads.BrandCarid,
                GearShiftBoxidDTO = ads.GearShiftBoxid,
                VolumeEngineCaridDTO = ads.VolumeEngineCarid,
                UserIdDTO = ads.UserId,
                AddDateAdsDTO = ads.AddDateAds,
                VisibleAdsDTO = ads.VisibleAds,
                PassedModerationDTO = ads.PassedModeration

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }

    }
}
