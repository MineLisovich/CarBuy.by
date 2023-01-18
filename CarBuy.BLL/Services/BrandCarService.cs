using System;
using System.Collections.Generic;
using System.Text;
using CarBuy.BLL.EntitiesDTO;
using CarBuy.BLL.Infrastructure;
using CarBuy.BLL.Interfaces;
using CarBuy.DAL.Entities;
using CarBuy.DAL.Interfaces;
using AutoMapper;


namespace CarBuy.BLL.Services
{
    public class BrandCarService : IBrandCarService
    {
        IUnitOfWork DataBase { get; set; }
        public BrandCarService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddBrandCar()
        {
            BrandCarDTO brandCarDTO = new BrandCarDTO();

            if (brandCarDTO == null)
            {
                throw new ValidationException("Введите марку автомобиля", "");
            }
            BrandCar brandCar = new BrandCar
            {
                NameBrandCar = brandCarDTO.NameBrandCarDTO
            };
            DataBase.BrandCar.SaveItem(brandCar);
            DataBase.Save();
        }
        public IEnumerable<BrandCarDTO> GetBrandCarsALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<BrandCar, BrandCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<BrandCar>, List<BrandCarDTO>>(DataBase.BrandCar.GetAll());
        }
        public BrandCarDTO GetBrandCarId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id марки", "");
            }
            var brand = DataBase.BrandCar.GetId(id.Value);
            if (brand == null) { throw new ValidationException("не найдено", ""); }

            return new BrandCarDTO
            {
                idDTO = brand.id,
                NameBrandCarDTO = brand.NameBrandCar

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }

    }
}
