using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class GearShiftBoxDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите наименование коробки переключения передач")]
        public string NameGearShiftBoxDTO { get; set; }
    }
}
