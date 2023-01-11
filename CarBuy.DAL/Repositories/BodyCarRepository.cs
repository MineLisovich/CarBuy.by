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
    public class BodyCarRepository : IRepository<BodyCar>
    {
        private AppDbContext db;

        public BodyCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<BodyCar> GetAll()
        {
            return db.BodyCar;
        }

        public BodyCar Get(int id)
        {
            return db.BodyCar.Find(id);
        }

        public void Create(BodyCar bodyCar)
        {
            db.BodyCar.Add(bodyCar);
        }

        public void Update(BodyCar bodyCar)
        {
            db.Entry(bodyCar).State = EntityState.Modified;
        }

        public IEnumerable<BodyCar> Find(Func<BodyCar, Boolean> predicate)
        {
            return db.BodyCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            BodyCar bodyCar = db.BodyCar.Find(id);
            if (bodyCar != null)
                db.BodyCar.Remove(bodyCar);
        }
    }
}
