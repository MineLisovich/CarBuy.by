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
    public class BrandCarRepository : IRepository<BrandCar>
    {
        private AppDbContext db;

        public BrandCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<BrandCar> GetAll()
        {
            return db.BrandCar;
        }

        public BrandCar Get(int id)
        {
            return db.BrandCar.Find(id);
        }

        public void Create(BrandCar brandCar)
        {
            db.BrandCar.Add(brandCar);
        }

        public void Update(BrandCar brandCar)
        {
            db.Entry(brandCar).State = EntityState.Modified;
        }

        public IEnumerable<BrandCar> Find(Func<BrandCar, Boolean> predicate)
        {
            return db.BrandCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            BrandCar brandCar = db.BrandCar.Find(id);
            if (brandCar != null)
                db.BrandCar.Remove(brandCar);
        }
    }
}
