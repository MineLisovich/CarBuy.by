using CarBuy.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBuy.BLL.EntitiesDTO
{
    public class AdsCarDTO
    {
        [Required]
        public int idDTO { get; set; }
        [Required(ErrorMessage = "Введите пробег автомобиля")]
        public int MileageDTO { get; set; } // Пробег
        [Required(ErrorMessage = "Введите цвет автомобиля")]
        public string ColorDTO { get; set; } // Цвет
        [Required(ErrorMessage = "Введите VIN номер автомобиля")]
        public string VINDTO { get; set; } // Вин номер
        [Required(ErrorMessage = "Введите цену")]
        public float PriceDTO { get; set; } // Цена
        [Required(ErrorMessage = "Напишите комментарий к объявлению")]
        public string SellersCommentDTO { get; set; } // Комментарий продовца
        [Required(ErrorMessage = "Укажите количество прошлых владельцев")]
        public string PastOwnersDTO { get; set; } // Прошлые владельцы (Пример: 1, 5 и больше)
        [Required(ErrorMessage = "Укажите количество л.с. двигателя")]
        public string HorsepowerDTO { get; set; } // Лошадиные силы двигателя
        [Required(ErrorMessage = "Укажите ПТС автомобиля")]
        public string PassportCarDTO { get; set; } // ПТС авто (ориг или не ориг)
        [Required(ErrorMessage = "Напишите кратко о мультимедии автомобиля")]
        public string MultimediaDTO { get; set; } // Мультимедия (Написать пару предложений о мультимедии)
        [Required(ErrorMessage = "Напишите кратко о системе безопасности автомобиля")]
        public string SafetyDTO { get; set; } // Безопасность (Написать пару предложений о безопасности)
        [Required(ErrorMessage = "Напишите кратко о элементах экстерьера автомобиля")]
        public string ExteriorElementsDTO { get; set; } // Элементы экстерьера (Написать пару предложений о экстерьере)
        [Required(ErrorMessage = "Укажите расположение руля")]
        public string RudderDTO { get; set; } // Руль (Право или лево сторонний)
        [Required(ErrorMessage = "Укажите состояние автомобиля")]
        public string ConditionDTO { get; set; } // Состояние авто (Требует ли он ремонта или нет)
        [Required(ErrorMessage = "Укажите данные про таможню")]
        public string CustomsDTO { get; set; } // Таможня (Растаможен или нет)
        [Required(ErrorMessage = "Укажите сколько владеете авто")]
        public string OwnershipDTO { get; set; } // Владение авто (Сколько лет/месяцев/ дней владеет авто)
        [Required]
        public string ModelCarAdsDTO { get; set; }
        [Required]
        public string GenerationModelAdsDTO { get; set; }

        // Поля для хранение картинок
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_1DTO { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_2DTO { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_3DTO { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_4DTO { get; set; }
        [Required(ErrorMessage = "Загрузите фото авто")]
        public string PhotoCar_5DTO { get; set; }

        // связи с таблицами
        public BrandCar BrandCarDTO { get; set; } // Марка авто
        public int BrandCaridDTO { get; set; }

        public BodyCar BodyCarDTO { get; set; }    // Кузов
        public int BodyCaridDTO { get; set; }
        public GearShiftBox GearShiftBoxDTO { get; set; } // КОробка
        public int GearShiftBoxidDTO { get; set; }
        public EngineCar EngineCarDTO { get; set; } // Тип Двигателя
        public int EngineCaridDTO { get; set; }
        public CarDrive CarDriveDTO { get; set; } // Привод автомобиля  
        public int CarDriveidDTO { get; set; }
        public VolumeEngineCar VolumeEngineCarDTO { get; set; } // Объём двигателя
        public int VolumeEngineCaridDTO { get; set; }
        public IdentityUser UserDTO { get; set; } //User
        public string UserIdDTO { get; set; }

        // Системные поля для админов и прочее
        [Required]
        public DateTime AddDateAdsDTO { get; set; }
        [Required]
        public bool VisibleAdsDTO { get; set; }
        [Required]
        public bool PassedModerationDTO { get; set; }



    }
}
