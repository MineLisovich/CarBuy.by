using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class BrandCarDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите бренд автомобиля")]
        public string NameBrandCarDTO { get; set; }
    }
}
