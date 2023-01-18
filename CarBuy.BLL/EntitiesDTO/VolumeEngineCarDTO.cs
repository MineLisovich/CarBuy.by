using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class VolumeEngineCarDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите объём двигателя")]
        public float VolumeEngineDTO { get; set; }
    }
}
