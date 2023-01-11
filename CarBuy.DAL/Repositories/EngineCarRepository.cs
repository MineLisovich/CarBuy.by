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

        public EngineCar Get(int id)
        {
            return db.EngineCar.Find(id);
        }

        public void Create(EngineCar engineCar)
        {
            db.EngineCar.Add(engineCar);
        }

        public void Update(EngineCar engineCar)
        {
            db.Entry(engineCar).State = EntityState.Modified;
        }

        public IEnumerable<EngineCar> Find(Func<EngineCar, Boolean> predicate)
        {
            return db.EngineCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            EngineCar engineCar = db.EngineCar.Find(id);
            if (engineCar != null)
                db.EngineCar.Remove(engineCar);
        }
    }

}
