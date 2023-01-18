using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class EngineCarDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите наименование двигателя")]
        public string NameEngineDTO { get; set; }
    }
}
