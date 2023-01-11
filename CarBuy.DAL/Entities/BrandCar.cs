using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class BrandCar //Таблица "Бренд автомобиля"
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "Введите бренд автомобиля")]
        public string NameBrandCar { get; set; }
    }
}
