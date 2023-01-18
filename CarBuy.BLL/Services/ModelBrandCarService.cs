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
    public class ModelBrandCarService : IModelBrandCarService
    {
        IUnitOfWork DataBase { get; set; }

        public ModelBrandCarService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddModelBrandCar()
        {
            BrandCarDTO brandCarDTO = new BrandCarDTO();

            BrandCar brandCar = DataBase.BrandCar.GetId(brandCarDTO.idDTO);
            if (brandCar == null) { throw new ValidationException("Марка не найдена", ""); }
            ModelBrandCarDTO modelBrandCarDTO = new ModelBrandCarDTO();

            ModelBrandCar modelBrandCar = new ModelBrandCar
            {
               NameModelBrand = modelBrandCarDTO.NameModelBrandDTO,
               BrandCarid = brandCar.id
            };
            DataBase.ModelBrandCar.SaveItem(modelBrandCar);
            DataBase.Save();
        }
        public IEnumerable<ModelBrandCarDTO> GetModelBrandCarALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ModelBrandCar, ModelBrandCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<ModelBrandCar>, List<ModelBrandCarDTO>>(DataBase.ModelBrandCar.GetAll());
        }
        public ModelBrandCarDTO GetModelBrandCarId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id марки", "");
            }
            var modelCar = DataBase.ModelBrandCar.GetId(id.Value);
            if (modelCar == null) { throw new ValidationException("не найдено", ""); }

            return new ModelBrandCarDTO
            {
                idDTO = modelCar.id,
              BrandCaridDTO = modelCar.BrandCarid,
              NameModelBrandDTO = modelCar.NameModelBrand

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
