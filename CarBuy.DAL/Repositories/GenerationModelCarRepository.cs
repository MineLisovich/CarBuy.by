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
    public class GenerationModelCarRepository : IRepository<GenerationModelCar>
    {
        private AppDbContext db;

        public GenerationModelCarRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<GenerationModelCar> GetAll()
        {
            return db.GenerationModelCar.Include(m=>m.ModelBrandCar).ThenInclude(b=>b.BrandCar);
        }

        public GenerationModelCar GetId(int id)
        {
            return db.GenerationModelCar.Include(m => m.ModelBrandCar).ThenInclude(b => b.BrandCar).FirstOrDefault(g => g.id == id);
        }

        public void SaveItem(GenerationModelCar entity)
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
            db.GenerationModelCar.Remove(new GenerationModelCar() { id = id });
            db.SaveChanges();
        }
    }
}
