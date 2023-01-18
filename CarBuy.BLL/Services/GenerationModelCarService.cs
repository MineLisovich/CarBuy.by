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
    public class GenerationModelCarService : IGenerationModelCarService
    {
        IUnitOfWork DataBase { get; set; }

        public GenerationModelCarService(IUnitOfWork uow)
        {
            DataBase = uow;
        }
        public void AddGenerationModelCar()
        {
            ModelBrandCarDTO modelBrandCarDTO = new ModelBrandCarDTO();

            ModelBrandCar modelBrandCar = DataBase.ModelBrandCar.GetId(modelBrandCarDTO.idDTO);
            if (modelBrandCar == null) { throw new ValidationException("Модель не найдена", ""); }
            GenerationModelCarDTO generationModelCarDTO = new GenerationModelCarDTO();

            GenerationModelCar generationModelCar = new GenerationModelCar
            {
                NameGenerationModel = generationModelCarDTO.NameGenerationModelDTO,
                ModelBrandCarid = modelBrandCar.id
            };
            DataBase.GenerationModelCar.SaveItem(generationModelCar);
            DataBase.Save();
        }
        public IEnumerable<GenerationModelCarDTO> GetGenerationModelCarALL()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GenerationModelCar, GenerationModelCarDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<GenerationModelCar>, List<GenerationModelCarDTO>>(DataBase.GenerationModelCar.GetAll());
        }
        public GenerationModelCarDTO GetGenerationModelCarId(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не установлено id покаления", "");
            }
            var generation = DataBase.GenerationModelCar.GetId(id.Value);
            if (generation == null) { throw new ValidationException("не найдено", ""); }

            return new GenerationModelCarDTO
            {
                idDTO = generation.id,
               ModelBrandCaridDTO = generation.ModelBrandCarid,
               NameGenerationModelDTO = generation.NameGenerationModel

            };
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
