using CarBuy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class GenerationModelCarDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите бренд автомобиля")]
        public string NameGenerationModelDTO { get; set; }
        // Связь с таблицей
        public ModelBrandCar ModelBrandCarDTO { get; set; }
        public int ModelBrandCaridDTO { get; set; }
    }
}
