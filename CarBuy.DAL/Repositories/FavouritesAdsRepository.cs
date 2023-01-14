using CarBuy.DAL.EF;
using CarBuy.DAL.Entities;
using CarBuy.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CarBuy.DAL.Repositories
{
    public class FavouritesAdsRepository : IRepository<FavouritesAds>
    {
        private AppDbContext db;

        public FavouritesAdsRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<FavouritesAds> GetAll()
        {
            return db.FavouritesAds;
        }

        public FavouritesAds GetId(int id)
        {
            return db.FavouritesAds.Find(id);
        }

        public void SaveItem(FavouritesAds entity)
        {
            if (entity.id == default)
            {
                db.Entry(entity).State = EntityState.Added;
            }
            else
            {
                db.Entry(entity).State = EntityState.Modified;
            }
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.FavouritesAds.Remove(new FavouritesAds() { id = id });
            db.SaveChanges();
        }
    }
}
