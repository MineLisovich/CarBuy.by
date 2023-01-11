using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class ModelBrandCar // Таблица "Модель марки автомобиля"
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "Введите бренд автомобиля")]
        public string NameModelBrand { get; set; }
        // Связь с таблицей
        public BrandCar BrandCar { get; set; }
        public int BrandCarid { get; set; }
       
    }
}
