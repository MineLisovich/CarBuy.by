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
    public class BodyCarService : IBodyCarService
    {
        IUnitOfWork DataBase { get; set; }


        public BodyCarService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddBodyCar()
        {
            BodyCarDTO bodyCarDTO = new BodyCarDTO();

            if (bodyCarDTO == null)
            {
                throw new ValidationException("Введите кузов автомобиля", "");
            }
            BodyCar bodyCar = new BodyCar
            {
                NameBodyCar = bodyCarDTO.NameBodyCarDTO
            };
            DataBase.BodyCar.SaveItem(bodyCar);
            DataBase.Save();
        }
        public IEnumerable<BodyCarDTO> GetBodyALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<BodyCar, BodyCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<BodyCar>, List<BodyCarDTO>>(DataBase.BodyCar.GetAll());
        }
        public BodyCarDTO GetBodyCarID(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id кузова", "");
            }
            var body = DataBase.BodyCar.GetId(id.Value);
            if (body == null) { throw new ValidationException("не найдено", ""); }

            return new BodyCarDTO
            {
                idDTO = body.id,
                NameBodyCarDTO = body.NameBodyCar

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
