using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBuy.DAL.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBodyCar = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyCar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BrandCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBrandCar = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandCar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CarDrive",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCarDrive = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDrive", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EngineCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEngine = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineCar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GearShiftBox",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGearShiftBox = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearShiftBox", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VolumeEngineCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolumeEngine = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolumeEngineCar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelBrandCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameModelBrand = table.Column<string>(nullable: false),
                    BrandCarid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelBrandCar", x => x.id);
                    table.ForeignKey(
                        name: "FK_ModelBrandCar_BrandCar_BrandCarid",
                        column: x => x.BrandCarid,
                        principalTable: "BrandCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdsCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mileage = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    VIN = table.Column<string>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    SellersComment = table.Column<string>(nullable: false),
                    PastOwners = table.Column<string>(nullable: false),
                    Horsepower = table.Column<string>(nullable: false),
                    PassportCar = table.Column<string>(nullable: false),
                    Multimedia = table.Column<string>(nullable: false),
                    Safety = table.Column<string>(nullable: false),
                    ExteriorElements = table.Column<string>(nullable: false),
                    Rudder = table.Column<string>(nullable: false),
                    Condition = table.Column<string>(nullable: false),
                    Customs = table.Column<string>(nullable: false),
                    Ownership = table.Column<string>(nullable: false),
                    ModelCarAds = table.Column<string>(nullable: false),
                    GenerationModelAds = table.Column<string>(nullable: false),
                    PhotoCar_1 = table.Column<string>(nullable: false),
                    PhotoCar_2 = table.Column<string>(nullable: false),
                    PhotoCar_3 = table.Column<string>(nullable: false),
                    PhotoCar_4 = table.Column<string>(nullable: false),
                    PhotoCar_5 = table.Column<string>(nullable: false),
                    BrandCarid = table.Column<int>(nullable: false),
                    BodyCarid = table.Column<int>(nullable: false),
                    GearShiftBoxid = table.Column<int>(nullable: false),
                    EngineCarid = table.Column<int>(nullable: false),
                    CarDriveid = table.Column<int>(nullable: false),
                    VolumeEngineCarid = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    AddDateAds = table.Column<DateTime>(nullable: false),
                    VisibleAds = table.Column<bool>(nullable: false),
                    PassedModeration = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdsCar", x => x.id);
                    table.ForeignKey(
                        name: "FK_AdsCar_BodyCar_BodyCarid",
                        column: x => x.BodyCarid,
                        principalTable: "BodyCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdsCar_BrandCar_BrandCarid",
                        column: x => x.BrandCarid,
                        principalTable: "BrandCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdsCar_CarDrive_CarDriveid",
                        column: x => x.CarDriveid,
                        principalTable: "CarDrive",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdsCar_EngineCar_EngineCarid",
                        column: x => x.EngineCarid,
                        principalTable: "EngineCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdsCar_GearShiftBox_GearShiftBoxid",
                        column: x => x.GearShiftBoxid,
                        principalTable: "GearShiftBox",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdsCar_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdsCar_VolumeEngineCar_VolumeEngineCarid",
                        column: x => x.VolumeEngineCarid,
                        principalTable: "VolumeEngineCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationModelCar",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGenerationModel = table.Column<string>(nullable: false),
                    ModelBrandCarid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationModelCar", x => x.id);
                    table.ForeignKey(
                        name: "FK_GenerationModelCar_ModelBrandCar_ModelBrandCarid",
                        column: x => x.ModelBrandCarid,
                        principalTable: "ModelBrandCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavouritesAds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdsCarid = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouritesAds", x => x.id);
                    table.ForeignKey(
                        name: "FK_FavouritesAds_AdsCar_AdsCarid",
                        column: x => x.AdsCarid,
                        principalTable: "AdsCar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouritesAds_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "603", "b0155ea0-580b-4f4d-b472-0f9583a00dd9", "moder", "MODER" },
                    { "602", "3bf64832-0472-4b90-9382-4c056c5cd041", "user", "USER" },
                    { "601", "e63d45c9-eb0e-46f5-8283-77107d5a80e3", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "703", 0, "ea3f669e-de33-4af8-9ad7-ea2973d89d77", "mod@gmail.com", true, false, null, "mod@gmail.com", "Moder", "AQAAAAEAACcQAAAAEBwqrp80oYu8OUCdrMc7IP9FHoYQMsb4oSWYMNqX9iMQQdWghXHxST94YY2F2U3eYA==", "+375231880433", false, "", false, "Moder" },
                    { "701", 0, "29f8b7d6-1792-424b-ba82-1709635f88a0", "deeLimpay@mail.ru", true, false, null, "deeLimpay@mail.ru", "deeLimpay", "AQAAAAEAACcQAAAAEA1Fjapb+rQFuJDQZIzhnjdYJU0h1EzFDmaVUMArs0mYtuAPlxPilLwMz3athe7aNw==", "+375433332323", false, "", false, "deeLimpay" },
                    { "702", 0, "ffd54552-8b98-405a-9fcd-1327e5deeeaf", "stepa@gmail.com", true, false, null, "stepa@gmail.com", "Stepashka", "AQAAAAEAACcQAAAAENWjuGM8EGjro3otyv679ILOvELFTPKRwcfA3XWZDDC39svhIHe3Pr6iHhzeDYFfKQ==", "+375231884433", false, "", false, "Stepashka" }
                });

            migrationBuilder.InsertData(
                table: "BodyCar",
                columns: new[] { "id", "NameBodyCar" },
                values: new object[,]
                {
                    { 10, "Фургон" },
                    { 9, "Кабриолет" },
                    { 1, "Седан" },
                    { 7, "Купе" },
                    { 2, "Внедорожник" },
                    { 6, "Минивэн" },
                    { 3, "Хэтчбек" },
                    { 4, "Лифтбек" },
                    { 5, "Универсал" },
                    { 8, "Пикап" }
                });

            migrationBuilder.InsertData(
                table: "BrandCar",
                columns: new[] { "id", "NameBrandCar" },
                values: new object[] { 1, "Audi" });

            migrationBuilder.InsertData(
                table: "CarDrive",
                columns: new[] { "id", "NameCarDrive" },
                values: new object[,]
                {
                    { 1, "Передний" },
                    { 2, "Задний" },
                    { 3, "Полный" }
                });

            migrationBuilder.InsertData(
                table: "EngineCar",
                columns: new[] { "id", "NameEngine" },
                values: new object[,]
                {
                    { 1, "Бензин" },
                    { 2, "Дизель" },
                    { 3, "Гибрит" },
                    { 4, "Электро" }
                });

            migrationBuilder.InsertData(
                table: "GearShiftBox",
                columns: new[] { "id", "NameGearShiftBox" },
                values: new object[,]
                {
                    { 2, "Механическая" },
                    { 4, "Вариатор" },
                    { 3, "Робот" },
                    { 1, "Автоматическая" }
                });

            migrationBuilder.InsertData(
                table: "VolumeEngineCar",
                columns: new[] { "id", "VolumeEngine" },
                values: new object[,]
                {
                    { 4, 0.4f },
                    { 5, 0.5f },
                    { 6, 0.6f },
                    { 7, 0.7f },
                    { 8, 0.8f },
                    { 9, 0.9f },
                    { 10, 1f },
                    { 11, 1.1f },
                    { 12, 1.2f },
                    { 1, 0.2f },
                    { 2, 0.2f },
                    { 3, 0.3f }
                });

            migrationBuilder.InsertData(
                table: "AdsCar",
                columns: new[] { "id", "AddDateAds", "BodyCarid", "BrandCarid", "CarDriveid", "Color", "Condition", "Customs", "EngineCarid", "ExteriorElements", "GearShiftBoxid", "GenerationModelAds", "Horsepower", "Mileage", "ModelCarAds", "Multimedia", "Ownership", "PassedModeration", "PassportCar", "PastOwners", "PhotoCar_1", "PhotoCar_2", "PhotoCar_3", "PhotoCar_4", "PhotoCar_5", "Price", "Rudder", "Safety", "SellersComment", "UserId", "VIN", "VisibleAds", "VolumeEngineCarid" },
                values: new object[] { 1, new DateTime(2023, 1, 18, 14, 35, 42, 102, DateTimeKind.Local).AddTicks(9615), 1, 1, 1, "Blue", "Не требует ремонта", "Растаможен", 1, "Чёткие диски и салон", 1, "2023", "2222", 2332, "rs7", "Мультимедия классная", "6 месяцев", true, "Orig", "1 Владелец", "1.png", "2.png", "3.png", "4.png", "5.png", 3999333f, "Левый руль", "Безопасность ВО!", "Машина классная", "702", "FJFEBHRBFJBRJH2348", true, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "701", "601" },
                    { "702", "602" },
                    { "703", "603" }
                });

            migrationBuilder.InsertData(
                table: "ModelBrandCar",
                columns: new[] { "id", "BrandCarid", "NameModelBrand" },
                values: new object[] { 1, 1, "rs7" });

            migrationBuilder.InsertData(
                table: "FavouritesAds",
                columns: new[] { "id", "AdsCarid", "UserId" },
                values: new object[] { 1, 1, "702" });

            migrationBuilder.InsertData(
                table: "GenerationModelCar",
                columns: new[] { "id", "ModelBrandCarid", "NameGenerationModel" },
                values: new object[] { 1, 1, "2019-2023 II(4K)" });

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_BodyCarid",
                table: "AdsCar",
                column: "BodyCarid");

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_BrandCarid",
                table: "AdsCar",
                column: "BrandCarid");

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_CarDriveid",
                table: "AdsCar",
                column: "CarDriveid");

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_EngineCarid",
                table: "AdsCar",
                column: "EngineCarid");

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_GearShiftBoxid",
                table: "AdsCar",
                column: "GearShiftBoxid");

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_UserId",
                table: "AdsCar",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdsCar_VolumeEngineCarid",
                table: "AdsCar",
                column: "VolumeEngineCarid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FavouritesAds_AdsCarid",
                table: "FavouritesAds",
                column: "AdsCarid");

            migrationBuilder.CreateIndex(
                name: "IX_FavouritesAds_UserId",
                table: "FavouritesAds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationModelCar_ModelBrandCarid",
                table: "GenerationModelCar",
                column: "ModelBrandCarid");

            migrationBuilder.CreateIndex(
                name: "IX_ModelBrandCar_BrandCarid",
                table: "ModelBrandCar",
                column: "BrandCarid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FavouritesAds");

            migrationBuilder.DropTable(
                name: "GenerationModelCar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AdsCar");

            migrationBuilder.DropTable(
                name: "ModelBrandCar");

            migrationBuilder.DropTable(
                name: "BodyCar");

            migrationBuilder.DropTable(
                name: "CarDrive");

            migrationBuilder.DropTable(
                name: "EngineCar");

            migrationBuilder.DropTable(
                name: "GearShiftBox");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "VolumeEngineCar");

            migrationBuilder.DropTable(
                name: "BrandCar");
        }
    }
}
