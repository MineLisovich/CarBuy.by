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
    public class GearShiftBoxService : IGearShiftBoxService
    {

        IUnitOfWork DataBase { get; set; }
        public GearShiftBoxService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddGearShiftBox()
        {
            GearShiftBoxDTO gearShiftBoxDTO = new GearShiftBoxDTO();

            if (gearShiftBoxDTO == null)
            {
                throw new ValidationException("Введите тип коробки передач", "");
            }
            GearShiftBox gearShiftBox = new GearShiftBox
            {
                NameGearShiftBox = gearShiftBoxDTO.NameGearShiftBoxDTO
            };
            DataBase.GearShiftBox.SaveItem(gearShiftBox);
            DataBase.Save();
        }
        public IEnumerable<GearShiftBoxDTO> GetGearShiftBoxALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GearShiftBox, GearShiftBoxDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<GearShiftBox>, List<GearShiftBoxDTO>>(DataBase.GearShiftBox.GetAll());
        }
        public GearShiftBoxDTO GetGearShiftBoxId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id коробки автомобиля", "");
            }
            var gearShiftBox = DataBase.GearShiftBox.GetId(id.Value);
            if (gearShiftBox == null) { throw new ValidationException("не найдено", ""); }

            return new GearShiftBoxDTO
            {
                idDTO = gearShiftBox.id,
                NameGearShiftBoxDTO = gearShiftBox.NameGearShiftBox
            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
