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
    public class EFUnitOfWork : IUnitOfWork
    {
        private AppDbContext db;

        private AdsCarRepository adsCarRepository;
        private BodyCarRepository bodyCarRepository;
        private BrandCarRepository brandCarRepository;
        private CarDriveRepository carDriveRepository;
        private EngineCarRepository engineCarRepository;
        private GearShiftBoxRepository gearShiftBoxRepository;
        private GenerationModelCarRepository generationModelCarRepository;
        private ModelBrandCarRepository modelBrandCarRepository;
        private VolumeEngineCarRepository volumeEngineCarRepository;

        public EFUnitOfWork(AppDbContext context)
        {
            this.db = context;
        }

        public IRepository<AdsCar> AdsCar
        {
            get
            {
                if (adsCarRepository == null)
                    adsCarRepository = new AdsCarRepository(db);
                return adsCarRepository;
            }
        }

        public IRepository<BodyCar> BodyCar
        {
            get
            {
                if (bodyCarRepository == null)
                    bodyCarRepository = new BodyCarRepository(db);
                return bodyCarRepository;
            }
        }
        public IRepository<BrandCar> BrandCar
        {
            get
            {
                if (brandCarRepository == null)
                    brandCarRepository = new BrandCarRepository(db);
                return brandCarRepository;
            }
        }
        public IRepository<CarDrive> CarDrive
        {
            get
            {
                if (carDriveRepository == null)
                    carDriveRepository = new CarDriveRepository(db);
                return carDriveRepository;
            }
        }
        public IRepository<EngineCar> EngineCar
        {
            get
            {
                if (engineCarRepository == null)
                    engineCarRepository = new EngineCarRepository(db);
                return engineCarRepository;
            }
        }
        public IRepository<GearShiftBox> GearShiftBox
        {
            get
            {
                if (gearShiftBoxRepository == null)
                    gearShiftBoxRepository = new GearShiftBoxRepository(db);
                return gearShiftBoxRepository;
            }
        }
        public IRepository<GenerationModelCar> GenerationModelCar
        {
            get
            {
                if (generationModelCarRepository == null)
                    generationModelCarRepository = new GenerationModelCarRepository(db);
                return generationModelCarRepository;
            }
        }

        public IRepository<ModelBrandCar> ModelBrandCar
        {
            get
            {
                if (modelBrandCarRepository == null)
                    modelBrandCarRepository = new ModelBrandCarRepository(db);
                return modelBrandCarRepository;
            }
        }
        public IRepository<VolumeEngineCar> VolumeEngineCar
        {
            get
            {
                if (volumeEngineCarRepository == null)
                    volumeEngineCarRepository = new VolumeEngineCarRepository(db);
                return volumeEngineCarRepository;
            }
        }




        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
