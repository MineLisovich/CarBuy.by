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
            return db.GenerationModelCar;
        }

        public GenerationModelCar Get(int id)
        {
            return db.GenerationModelCar.Find(id);
        }

        public void Create(GenerationModelCar generationModelCar)
        {
            db.GenerationModelCar.Add(generationModelCar);
        }

        public void Update(GenerationModelCar generationModelCar)
        {
            db.Entry(generationModelCar).State = EntityState.Modified;
        }

        public IEnumerable<GenerationModelCar> Find(Func<GenerationModelCar, Boolean> predicate)
        {
            return db.GenerationModelCar.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            GenerationModelCar generationModelCar = db.GenerationModelCar.Find(id);
            if (generationModelCar != null)
                db.GenerationModelCar.Remove(generationModelCar);
        }
    }
}
