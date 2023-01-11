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

        public CarDrive Get(int id)
        {
            return db.CarDrive.Find(id);
        }

        public void Create(CarDrive carDrive)
        {
            db.CarDrive.Add(carDrive);
        }

        public void Update(CarDrive carDrive)
        {
            db.Entry(carDrive).State = EntityState.Modified;
        }

        public IEnumerable<CarDrive> Find(Func<CarDrive, Boolean> predicate)
        {
            return db.CarDrive.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            CarDrive carDrive = db.CarDrive.Find(id);
            if (carDrive != null)
                db.CarDrive.Remove(carDrive);
        }
    }
}
