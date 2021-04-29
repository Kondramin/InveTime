using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InveTime.DataBase.DLL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateInventarisations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventarisationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateInventarisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountData = table.Column<int>(type: "int", nullable: false),
                    AmountFact = table.Column<int>(type: "int", nullable: false),
                    AmountResult = table.Column<int>(type: "int", nullable: false),
                    Peresort = table.Column<bool>(type: "bit", nullable: false),
                    TypeProductId = table.Column<int>(type: "int", nullable: true),
                    DateInventarisationId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_DateInventarisations_DateInventarisationId",
                        column: x => x.DateInventarisationId,
                        principalTable: "DateInventarisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TypeProducts_TypeProductId",
                        column: x => x.TypeProductId,
                        principalTable: "TypeProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "AccessLevel", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Administrator" },
                    { 2, 2, "Менеджер магазина" },
                    { 3, 1, "Продавец" }
                });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 22, "Освещение" },
                    { 21, "Транспорт" },
                    { 20, "Техника для уборки" },
                    { 19, "Умный дом" },
                    { 18, "Медиаплееры" },
                    { 17, "Телевизоры" },
                    { 16, "Сетевое оборудование" },
                    { 15, "Гарнитуры" },
                    { 14, "Портативные колонки" },
                    { 13, "Мыши компьютерные" },
                    { 12, "IP-камеры" },
                    { 11, "Батарейки" },
                    { 10, "Карты памяти" },
                    { 9, "Видеорегистраторы" },
                    { 8, "Ремешки для часов/браслетов" },
                    { 7, "Умные часы/браслеты" },
                    { 6, "Защитные стёкла/плёнки" },
                    { 5, "Чехлы для телефонов" },
                    { 4, "Мобильные телефоны" },
                    { 3, "Рюкзаки/сумки/чемоданы" },
                    { 2, "Ноутбуки" },
                    { 1, "Внешние аккумуляторы" },
                    { 23, "Кабели" },
                    { 24, "Прочее" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Login", "Name", "Password", "Patronymic", "PositionId", "SecondName" },
                values: new object[] { 1, null, "Admin", "Admin", "Admin", null, 1, "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DateInventarisationId",
                table: "Products",
                column: "DateInventarisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeProductId",
                table: "Products",
                column: "TypeProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "DateInventarisations");

            migrationBuilder.DropTable(
                name: "TypeProducts");
        }
    }
}
