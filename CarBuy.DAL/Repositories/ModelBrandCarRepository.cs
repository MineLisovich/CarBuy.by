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
    public class ModelBrandCarRepository : IRepository<ModelBrandCar>
    {
        private AppDbContext db;

        public ModelBrandCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<ModelBrandCar> GetAll()
        {
            return db.ModelBrandCar;
        }

        public ModelBrandCar Get(int id)
        {
            return db.ModelBrandCar.Find(id);
        }

        public void Create(ModelBrandCar modelBrandCar)
        {
            db.ModelBrandCar.Add(modelBrandCar);
        }

        public void Update(ModelBrandCar modelBrandCar)
        {
            db.Entry(modelBrandCar).State = EntityState.Modified;
        }

        public IEnumerable<ModelBrandCar> Find(Func<ModelBrandCar, Boolean> predicate)
        {
            return db.ModelBrandCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ModelBrandCar modelBrandCar = db.ModelBrandCar.Find(id);
            if (modelBrandCar != null)
                db.ModelBrandCar.Remove(modelBrandCar);
        }
    }
}
