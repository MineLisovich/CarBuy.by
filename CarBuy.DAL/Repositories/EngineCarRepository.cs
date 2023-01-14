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
    public class EngineCarRepository : IRepository<EngineCar>
    {
        private AppDbContext db;

        public EngineCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<EngineCar> GetAll()
        {
            return db.EngineCar;
        }

        public EngineCar GetId(int id)
        {
            return db.EngineCar.Find(id);
        }

        public void SaveItem(EngineCar entity)
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
            db.EngineCar.Remove(new EngineCar() { id = id });
            db.SaveChanges();
        }
    }

}
