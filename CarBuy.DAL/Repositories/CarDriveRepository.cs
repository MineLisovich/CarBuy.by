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
    public class CarDriveRepository : IRepository<CarDrive>
    {
        private AppDbContext db;

        public CarDriveRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<CarDrive> GetAll()
        {
            return db.CarDrive;
        }

        public CarDrive GetId(int id)
        {
            return db.CarDrive.Find(id);
        }

        public void SaveItem(CarDrive entity)
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

            db.CarDrive.Remove(new CarDrive() { id = id });
            db.SaveChanges();
        }
    }
}
