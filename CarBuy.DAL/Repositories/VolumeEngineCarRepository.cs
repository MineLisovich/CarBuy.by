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
    public class VolumeEngineCarRepository : IRepository<VolumeEngineCar>
    {
        private AppDbContext db;

        public VolumeEngineCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<VolumeEngineCar> GetAll()
        {
            return db.VolumeEngineCar;
        }

        public VolumeEngineCar GetId(int id)
        {
            return db.VolumeEngineCar.Find(id);
        }

        public void SaveItem(VolumeEngineCar entity)
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
            db.VolumeEngineCar.Remove(new VolumeEngineCar() { id = id });
            db.SaveChanges();
        }
    }
}
