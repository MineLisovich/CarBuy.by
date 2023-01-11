using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class GenerationModelCar // Таблица "Поколение модели автомобиля"
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "Введите бренд автомобиля")]
        public string NameGenerationModel { get; set; }
        // Связь с таблицей
        public ModelBrandCar ModelBrandCar { get; set; }
        public int ModelBrandCarid { get; set; }
    }
}
