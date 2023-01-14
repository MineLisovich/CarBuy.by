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

        public BrandCar GetId(int id)
        {
            return db.BrandCar.Find(id);
        }

        public void SaveItem(BrandCar entity)
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
            db.BrandCar.Remove(new BrandCar() { id = id });
            db.SaveChanges();
        }
    }
}
