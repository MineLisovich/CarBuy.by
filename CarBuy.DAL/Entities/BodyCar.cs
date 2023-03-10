using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBuy.DAL.Entities
{
    public class BodyCar //Таблица "Кузов автомобиля"
    {
        [Required]
        public int id { get; set; }
        [Required (ErrorMessage ="Введите кузов автомобиля")]
        public string NameBodyCar { get; set; }    

    }
}
