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
            return db.AdsCar.Include(br=>br.BrandCar).Include(bo=>bo.BodyCar).Include(g=>g.GearShiftBox).Include(e=>e.EngineCar).Include(c=>c.CarDrive).Include(v=>v.VolumeEngineCar).Include(u=>u.User);
        }

        public AdsCar GetId(int id)
        {
            return db.AdsCar.Include(br => br.BrandCar).Include(bo => bo.BodyCar).Include(g => g.GearShiftBox).Include(e => e.EngineCar).Include(c => c.CarDrive).Include(v => v.VolumeEngineCar).Include(u => u.User).FirstOrDefault(a=>a.id == id);
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
