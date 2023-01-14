using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CarBuy.DAL.Entities;
using System.Threading;
using CarBuy.DAL.DataContext;


namespace CarBuy.DAL.EF
{
    public class AppDbContext : IdentityDbContext<IdentityUser>// DbContext//
    {

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

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
   
        public DbSet<AdsCar> AdsCar { get; set; }
        public DbSet<BodyCar> BodyCar { get; set; }
        public DbSet<BrandCar> BrandCar { get; set; }
        public DbSet<CarDrive> CarDrive { get; set; }
        public DbSet<EngineCar> EngineCar { get; set; }
        public DbSet<GearShiftBox> GearShiftBox { get; set; }
        public DbSet<GenerationModelCar> GenerationModelCar { get; set; }
        public DbSet<ModelBrandCar> ModelBrandCar { get; set; }
        public DbSet<VolumeEngineCar> VolumeEngineCar { get; set; }
        public DbSet<FavouritesAds> FavouritesAds { get; set; }
        public DbContextOptions<AppDbContext> ConnectionString { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Заполение таблицы BrandCar
            modelBuilder.Entity<BrandCar>().HasData(new BrandCar
            {
                id = 1,
                NameBrandCar = "Audi"
            });
            //Заполение таблицы ModelBrandCar
            modelBuilder.Entity<ModelBrandCar>().HasData(new ModelBrandCar
            {
                id = 1,
                NameModelBrand = "rs7",
                BrandCarid = 1
            });
            //Заполение таблицы GenerationModelCar
            modelBuilder.Entity<GenerationModelCar>().HasData(new GenerationModelCar
            {
                id = 1,
                NameGenerationModel = "2019-2023 II(4K)",
                ModelBrandCarid = 1
            });
            //Заполение таблицы BodyCar
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 1,
                NameBodyCar = "Седан"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 2,
                NameBodyCar = "Внедорожник"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 3,
                NameBodyCar = "Хэтчбек"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 4,
                NameBodyCar = "Лифтбек"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 5,
                NameBodyCar = "Универсал"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 6,
                NameBodyCar = "Минивэн"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 7,
                NameBodyCar = "Купе"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 8,
                NameBodyCar = "Пикап"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 9,
                NameBodyCar = "Кабриолет"
            });
            modelBuilder.Entity<BodyCar>().HasData(new BodyCar
            {
                id = 10,
                NameBodyCar = "Фургон"
            });
            //Заполение таблицы GearShiftBox
            modelBuilder.Entity<GearShiftBox>().HasData(new GearShiftBox
            {
                id = 1,
                NameGearShiftBox = "Автоматическая"
            });
            modelBuilder.Entity<GearShiftBox>().HasData(new GearShiftBox
            {
                id = 2,
                NameGearShiftBox = "Механическая"
            });
            modelBuilder.Entity<GearShiftBox>().HasData(new GearShiftBox
            {
                id = 3,
                NameGearShiftBox = "Робот"
            });
            modelBuilder.Entity<GearShiftBox>().HasData(new GearShiftBox
            {
                id = 4,
                NameGearShiftBox = "Вариатор"
            });
            //Заполение таблицы EngineCar
            modelBuilder.Entity<EngineCar>().HasData(new EngineCar
            {
                id = 1,
                NameEngine = "Бензин"
            });
            modelBuilder.Entity<EngineCar>().HasData(new EngineCar
            {
                id = 2,
                NameEngine = "Дизель"
            });
            modelBuilder.Entity<EngineCar>().HasData(new EngineCar
            {
                id = 3,
                NameEngine = "Гибрит"
            });
            modelBuilder.Entity<EngineCar>().HasData(new EngineCar
            {
                id = 4,
                NameEngine = "Электро"
            });
            //Заполение таблицы CarDrive
            modelBuilder.Entity<CarDrive>().HasData(new CarDrive
            {
                id = 1,
                NameCarDrive = "Передний"
            });
            modelBuilder.Entity<CarDrive>().HasData(new CarDrive
            {
                id = 2,
                NameCarDrive = "Задний"
            });
            modelBuilder.Entity<CarDrive>().HasData(new CarDrive
            {
                id = 3,
                NameCarDrive = "Полный"
            });
            //Заполение таблицы VolumeEngineCar
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 1,
                VolumeEngine = 0.2f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 2,
                VolumeEngine = 0.2f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 3,
                VolumeEngine = 0.3f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 4,
                VolumeEngine = 0.4f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 5,
                VolumeEngine = 0.5f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 6,
                VolumeEngine = 0.6f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 7,
                VolumeEngine = 0.7f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 8,
                VolumeEngine = 0.8f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 9,
                VolumeEngine = 0.9f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 10,
                VolumeEngine = 1.0f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 11,
                VolumeEngine = 1.1f
            });
            modelBuilder.Entity<VolumeEngineCar>().HasData(new VolumeEngineCar
            {
                id = 12,
                VolumeEngine = 1.2f
            });
            // Identity user and roles and userroles
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "601",
                Name = "admin",
                NormalizedName = "ADMIN"

            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "602",
                Name = "user",
                NormalizedName = "USER",

            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "701",
                UserName = "deeLimpay",
                NormalizedUserName = "deeLimpay",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin1"),
                SecurityStamp = string.Empty,
                Email = "deeLimpay@mail.ru",
                NormalizedEmail = "deeLimpay@mail.ru",
                EmailConfirmed = true,
                PhoneNumber = "+375433332323"
            });


            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "702",
                UserName = "Stepashka",
                NormalizedUserName = "Stepashka",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "user11"),
                SecurityStamp = string.Empty,
                Email = "stepa@gmail.com",
                NormalizedEmail = "stepa@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "+375231884433"


            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "701",
                RoleId = "601"

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "702",
                RoleId = "602"

            });
            //Заполение таблицы AdsCar
            modelBuilder.Entity<AdsCar>().HasData(new AdsCar
            {
                id = 1,
                Mileage = 2332,
                Color = "Blue",
                VIN = "FJFEBHRBFJBRJH2348",
                Price = 3999333.0f,
                SellersComment = "Машина классная",
                PastOwners = "1 Владелец",
                Horsepower = "2222",
                PassportCar = "Orig",
                Multimedia = "Мультимедия классная",
                Safety = "Безопасность ВО!",
                ExteriorElements = "Чёткие диски и салон",
                Rudder ="Левый руль",
                Condition = "Не требует ремонта",
                Customs = "Растаможен",
                Ownership = "6 месяцев",
                PhotoCar_1 = "1.png",
                PhotoCar_2 = "2.png",
                PhotoCar_3 = "3.png",
                PhotoCar_4 = "4.png",
                PhotoCar_5 = "5.png",
                BrandCarid = 1,
                BodyCarid =1,
                GearShiftBoxid = 1,
                EngineCarid=1,
                CarDriveid = 1,
                VolumeEngineCarid = 1,
                UserId = "702",
                AddDateAds = DateTime.Now,
                VisibleAds = true,
                PassedModeration = true
            });
            //
            modelBuilder.Entity<FavouritesAds>().HasData(new FavouritesAds { 
            id = 1,
            AdsCarid = 1,   
            UserId ="702"
            });
        }
    }
}






