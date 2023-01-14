using CarBuy.DAL.DataContext;
using CarBuy.DAL.EF;
using CarBuy.DAL.Entities;
using CarBuy.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
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
        private FavouritesAdsRepository favouritesAdsRepository;

        //public EFUnitOfWork(AppDbContext context)
        //{
        //    this.db = context;
        //}
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                _appConfiguration = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                opsBuilder.UseSqlServer(_appConfiguration.sqlConnectionString);
                dbOptins = opsBuilder.Options;
            }
            public DbContextOptionsBuilder<AppDbContext> opsBuilder { get; set; }
            public DbContextOptions<AppDbContext> dbOptins { get; set; }
            private AppConfiguration _appConfiguration { get; set; }
        }
        public static OptionsBuild ops = new OptionsBuild();
        public EFUnitOfWork(DbContextOptions<AppDbContext> options)
        {
            db = new AppDbContext(options);
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
        public IRepository<FavouritesAds> FavouritesAds
        {
            get
            {
                if (favouritesAdsRepository == null)
                    favouritesAdsRepository = new FavouritesAdsRepository(db);
                return favouritesAdsRepository;
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
