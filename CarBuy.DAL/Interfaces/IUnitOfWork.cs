using CarBuy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CarBuy.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<AdsCar> AdsCar { get; }
        IRepository<BodyCar> BodyCar { get; }
        IRepository<BrandCar> BrandCar { get; }
        IRepository<CarDrive> CarDrive { get; }
        IRepository<EngineCar> EngineCar { get; }
        IRepository<GearShiftBox> GearShiftBox { get; }
        IRepository<GenerationModelCar> GenerationModelCar { get; }
        IRepository<ModelBrandCar> ModelBrandCar { get; }
        IRepository<VolumeEngineCar> VolumeEngineCar { get; }
        IRepository<FavouritesAds> FavouritesAds { get; }

        void Save();
    }
}
