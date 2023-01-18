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
    public class EngineCarService : IEngineCarService
    {
        IUnitOfWork DataBase { get; set; }
        public EngineCarService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddEngineCar()
        {
            EngineCarDTO engineCarDTO = new EngineCarDTO();

            if (engineCarDTO == null)
            {
                throw new ValidationException("Введите тип двигателя", "");
            }
            EngineCar engineCar = new EngineCar
            {
                NameEngine = engineCarDTO.NameEngineDTO
            };
            DataBase.EngineCar.SaveItem(engineCar);
            DataBase.Save();
        }
        public IEnumerable<EngineCarDTO> GetEngineALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<EngineCar, EngineCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<EngineCar>, List<EngineCarDTO>>(DataBase.EngineCar.GetAll());
        }
        public EngineCarDTO GetEngineCarId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id двигателя автомобиля", "");
            }
            var engine = DataBase.EngineCar.GetId(id.Value);
            if (engine == null) { throw new ValidationException("не найдено", ""); }

            return new EngineCarDTO
            {
                idDTO = engine.id,
                NameEngineDTO = engine.NameEngine

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
