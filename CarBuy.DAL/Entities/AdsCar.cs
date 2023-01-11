using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.DAL.Entities
{
    public class AdsCar
    {
        [Required]
        public int id { get; set; }
        [Required (ErrorMessage ="Введите пробег автомобиля")]
        public int Mileage { get; set; } // Пробег
        [Required(ErrorMessage = "Введите цвет автомобиля")]
        public string Color { get; set; } // Цвет
        [Required(ErrorMessage = "Введите VIN номер автомобиля")]
        public string VIN { get; set; } // Вин номер
        [Required(ErrorMessage = "Введите цену")]
        public float Price { get; set; } // Цена
        [Required(ErrorMessage = "Напишите комментарий к объявлению")]
        public string SellersComment { get; set; } // Комментарий продовца
        [Required(ErrorMessage = "Укажите количество прошлых владельцев")]
        public string PastOwners { get; set; } // Прошлые владельцы (Пример: 1, 5 и больше)
        [Required(ErrorMessage = "Укажите количество л.с. двигателя")]
        public string Horsepower { get; set; } // Лошадиные силы двигателя
        [Required(ErrorMessage = "Укажите ПТС автомобиля")]
        public string PassportCar { get; set; } // ПТС авто (ориг или не ориг)
        [Required(ErrorMessage = "Напишите кратко о мультимедии автомобиля")]
        public string Multimedia { get; set; } // Мультимедия (Написать пару предложений о мультимедии)
        [Required(ErrorMessage = "Напишите кратко о системе безопасности автомобиля")]
        public string Safety { get; set; } // Безопасность (Написать пару предложений о безопасности)
        [Required(ErrorMessage = "Напишите кратко о элементах экстерьера автомобиля")]
        public string ExteriorElements { get; set; } // Элементы экстерьера (Написать пару предложений о экстерьере)
        [Required(ErrorMessage = "Укажите расположение руля")]
        public string Rudder { get; set; } // Руль (Право или лево сторонний)
        [Required(ErrorMessage = "Укажите состояние автомобиля")]
        public string Condition { get; set; } // Состояние авто (Требует ли он ремонта или нет)
        [Required(ErrorMessage = "Укажите данные про таможню")]
        public string Customs { get; set; } // Таможня (Растаможен или нет)
        [Required(ErrorMessage = "Укажите сколько владеете авто")]
        public string Ownership { get; set; } // Владение авто (Сколько лет/месяцев/ дней владеет авто)
        // Поля для хранение картинок
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_1 { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_2 { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_3 { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_4 { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_5 { get; set; }

        // связи с таблицами
        public BrandCar BrandCar { get; set; } // Марка авто
        public int BrandCarid { get; set; }

        public BodyCar BodyCar { get; set; }    // Кузов
        public int BodyCarid { get; set; }  
        public GearShiftBox GearShiftBox  { get; set; } // КОробка
        public int GearShiftBoxid { get; set; }
        public EngineCar EngineCar { get; set; } // Тип Двигателя
        public int EngineCarid { get; set; } 
        public CarDrive CarDrive { get; set; } // Привод автомобиля  
        public int CarDriveid { get; set; }
        public VolumeEngineCar VolumeEngineCar { get; set; } // Объём двигателя
        public int VolumeEngineCarid { get; set; }
        public IdentityUser User { get; set; } //User
        public string UserId { get; set; }

        // Системные поля для админов и прочее
        [Required]
        public DateTime AddDateAds { get; set; }
        [Required]
        public bool VisibleAds { get; set; }
        [Required]
        public bool PassedModeration { get; set; }



    }
}
