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

        public ModelBrandCar GetId(int id)
        {
            return db.ModelBrandCar.Find(id);
        }

        public void SaveItem(ModelBrandCar entity)
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
            db.ModelBrandCar.Remove(new ModelBrandCar() { id = id });
            db.SaveChanges();
        }
    }
}
