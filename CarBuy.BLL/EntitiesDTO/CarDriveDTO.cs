using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class CarDriveDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите привод автомобиля")]
        public string NameCarDriveDTO { get; set; }
    }
}
