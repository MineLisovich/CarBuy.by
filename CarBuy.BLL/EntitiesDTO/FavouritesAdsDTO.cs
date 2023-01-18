using CarBuy.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class FavouritesAdsDTO
    {
        [Required]
        public int idDTO { get; set; }

        public AdsCar AdsCarDTO { get; set; }
        public int AdsCaridDTO { get; set; }

        public IdentityUser UserDTO { get; set; } //User
        public string UserIdDTO { get; set; }
    }
}
