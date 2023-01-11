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

        public VolumeEngineCar Get(int id)
        {
            return db.VolumeEngineCar.Find(id);
        }

        public void Create(VolumeEngineCar volumeEngineCar)
        {
            db.VolumeEngineCar.Add(volumeEngineCar);
        }

        public void Update(VolumeEngineCar volumeEngineCar)
        {
            db.Entry(volumeEngineCar).State = EntityState.Modified;
        }

        public IEnumerable<VolumeEngineCar> Find(Func<VolumeEngineCar, Boolean> predicate)
        {
            return db.VolumeEngineCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            VolumeEngineCar volumeEngineCar = db.VolumeEngineCar.Find(id);
            if (volumeEngineCar != null)
                db.VolumeEngineCar.Remove(volumeEngineCar);
        }
    }
}
