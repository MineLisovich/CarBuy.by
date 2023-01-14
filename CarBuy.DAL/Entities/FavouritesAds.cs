using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class FavouritesAds
    {
        [Required]
        public int id { get; set; }
        
        public AdsCar AdsCar { get; set; }
        public int AdsCarid { get; set; }

        public IdentityUser User { get; set; } //User
        public string UserId { get; set; }
    }
}
