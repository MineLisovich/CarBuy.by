using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class VolumeEngineCar //Таблица "Объём двигателя"
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "Введите объём двигателя")]
        public float VolumeEngine { get; set; }
    }
}
