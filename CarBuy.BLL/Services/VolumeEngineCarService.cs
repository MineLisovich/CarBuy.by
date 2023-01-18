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
    public class VolumeEngineCarService : IVolumeEngineCarService
    {
        IUnitOfWork DataBase { get; set; }
        public VolumeEngineCarService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddVolumeEngineCar()
        {
            VolumeEngineCarDTO volumeEngineCarDTO = new VolumeEngineCarDTO();

            if (volumeEngineCarDTO == null)
            {
                throw new ValidationException("Ввеберите объём двигателя", "");
            }
            VolumeEngineCar volumeEngineCar = new VolumeEngineCar
            {
                VolumeEngine = volumeEngineCarDTO.VolumeEngineDTO
            };
            DataBase.VolumeEngineCar.SaveItem(volumeEngineCar);
            DataBase.Save();
        }
        public IEnumerable<VolumeEngineCarDTO> GetVolumeEngineCarALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<VolumeEngineCar, VolumeEngineCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<VolumeEngineCar>, List<VolumeEngineCarDTO>>(DataBase.VolumeEngineCar.GetAll());
        }
        public VolumeEngineCarDTO GetVolumeEngineCarId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id объёма двигателя", "");
            }
            var volumeEngineCar = DataBase.VolumeEngineCar.GetId(id.Value);
            if (volumeEngineCar == null) { throw new ValidationException("не найдено", ""); }

            return new VolumeEngineCarDTO
            {
                idDTO = volumeEngineCar.id,
                VolumeEngineDTO = volumeEngineCar.VolumeEngine
            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
