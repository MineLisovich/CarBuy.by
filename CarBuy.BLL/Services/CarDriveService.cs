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
    public class CarDriveService : ICarDriveService
    {
        IUnitOfWork DataBase { get; set; }
        public CarDriveService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddCarDrive()
        {
            CarDriveDTO carDriveDTO = new CarDriveDTO();

            if (carDriveDTO == null)
            {
                throw new ValidationException("Введите привод автомобиля", "");
            }
            CarDrive carDrive = new CarDrive
            {
                NameCarDrive = carDriveDTO.NameCarDriveDTO
            };
            DataBase.CarDrive.SaveItem(carDrive);
            DataBase.Save();
        }
        public IEnumerable<CarDriveDTO> GetCarDriveALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CarDrive, CarDriveDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<CarDrive>, List<CarDriveDTO>>(DataBase.CarDrive.GetAll());
        }
        public CarDriveDTO GetCarDriveId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id привода автомобиля", "");
            }
            var carDr = DataBase.CarDrive.GetId(id.Value);
            if (carDr == null) { throw new ValidationException("не найдено", ""); }

            return new CarDriveDTO
            {
                idDTO = carDr.id,
                NameCarDriveDTO = carDr.NameCarDrive

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }

    }
}
