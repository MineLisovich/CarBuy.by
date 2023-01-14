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
    public class AdsCarRepository : IRepository<AdsCar>
    {
        private AppDbContext db;

        public AdsCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<AdsCar> GetAll()
        {
            return db.AdsCar;
        }

        public AdsCar GetId(int id)
        {
            return db.AdsCar.Find(id);
        }

       public void SaveItem (AdsCar entity)
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
            db.AdsCar.Remove(new AdsCar() { id = id });
            db.SaveChanges();
        }
    }
}
