using CarBuy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class ModelBrandCarDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите бренд автомобиля")]
        public string NameModelBrandDTO { get; set; }
        // Связь с таблицей
        public BrandCar BrandCarDTO { get; set; }
        public int BrandCaridDTO { get; set; }
    }
}
