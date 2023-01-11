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

        public GearShiftBox Get(int id)
        {
            return db.GearShiftBox.Find(id);
        }

        public void Create(GearShiftBox gearShiftBox)
        {
            db.GearShiftBox.Add(gearShiftBox);
        }

        public void Update(GearShiftBox gearShiftBox)
        {
            db.Entry(gearShiftBox).State = EntityState.Modified;
        }

        public IEnumerable<GearShiftBox> Find(Func<GearShiftBox, Boolean> predicate)
        {
            return db.GearShiftBox.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            GearShiftBox gearShiftBox = db.GearShiftBox.Find(id);
            if (gearShiftBox != null)
                db.GearShiftBox.Remove(gearShiftBox);
        }
    }
}
