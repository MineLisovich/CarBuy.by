using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBuy.DAL.Entities
{
    public class GearShiftBox //Таблица "Коробка переключения передач"
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "Введите наименование коробки переключения передач")]
        public string NameGearShiftBox { get; set; }
    }
}
