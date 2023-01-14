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

        public BodyCar GetId(int id)
        {
            return db.BodyCar.Find(id);
        }
        public void SaveItem(BodyCar entity)
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
            db.BodyCar.Remove(new BodyCar() { id = id });
            db.SaveChanges();
        }
    }
}
