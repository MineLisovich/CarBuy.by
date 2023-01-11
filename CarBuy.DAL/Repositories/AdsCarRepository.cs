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

        public AdsCar Get(int id)
        {
            return db.AdsCar.Find(id);
        }

        public void Create(AdsCar adsCar)
        {
            db.AdsCar.Add(adsCar);
        }

        public void Update(AdsCar adsCar)
        {
            db.Entry(adsCar).State = EntityState.Modified;
        }

        public IEnumerable<AdsCar> Find(Func<AdsCar, Boolean> predicate)
        {
            return db.AdsCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            AdsCar adsCar = db.AdsCar.Find(id);
            if (adsCar != null)
                db.AdsCar.Remove(adsCar);
        }
    }
}
