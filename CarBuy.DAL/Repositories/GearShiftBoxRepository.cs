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
    public class GearShiftBoxRepository : IRepository<GearShiftBox>
    {
        private AppDbContext db;

        public GearShiftBoxRepository(AppDbContext context)
        {
            this.db = context;
        }
        public IEnumerable<GearShiftBox> GetAll()
        {
            return db.GearShiftBox;
        }

        public GearShiftBox GetId(int id)
        {
            return db.GearShiftBox.Find(id);
        }

        public void SaveItem(GearShiftBox entity)
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
            db.GearShiftBox.Remove(new GearShiftBox() { id = id });
            db.SaveChanges();
        }
    }
}
