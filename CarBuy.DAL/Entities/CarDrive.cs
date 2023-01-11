using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class CarDrive //Таблица "Привод автомобиля"
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "Введите привод автомобиля")]
        public string NameCarDrive { get; set; }
    }
}
