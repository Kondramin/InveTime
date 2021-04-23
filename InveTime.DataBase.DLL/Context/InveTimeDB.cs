using InveTime.DataBase.DLL.Entityes;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace InveTime.DataBase.DLL.Context
{
    class InveTimeDB : DbContext
    {


        #region Entityes


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TypeProduct> TypeProduct { get; set; }
        public DbSet<DateInventarisation> DateInventarisations { get; set; }


        #endregion


        public InveTimeDB([NotNullAttribute] DbContextOptions options) : base(options) { }



        #region Initial Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeProduct>().HasData(
                new TypeProduct[]
                {
                new TypeProduct { Id=1, Name="Внешние аккумуляторы" },
                new TypeProduct { Id=2, Name="Ноутбуки" },
                new TypeProduct { Id=3, Name="Рюкзаки/сумки/чемоданы" },
                new TypeProduct { Id=4, Name="Мобильные телефоны" },
                new TypeProduct { Id=5, Name="Чехлы для телефонов" },
                new TypeProduct { Id=6, Name="Защитные стёкла/плёнки" },
                new TypeProduct { Id=7, Name="Умные часы/браслеты" },
                new TypeProduct { Id=8, Name="Ремешки для часов/браслетов" },
                new TypeProduct { Id=9, Name="Видеорегистраторы" },
                new TypeProduct { Id=10, Name="Карты памяти" },
                new TypeProduct { Id=11, Name="Батарейки" },
                new TypeProduct { Id=12, Name="IP-камеры" },
                new TypeProduct { Id=13, Name="Мыши компьютерные" },
                new TypeProduct { Id=14, Name="Портативные колонки" },
                new TypeProduct { Id=15, Name="Гарнитуры" },
                new TypeProduct { Id=16, Name="Сетевое оборудование" },
                new TypeProduct { Id=17, Name="Телевизоры" },
                new TypeProduct { Id=18, Name="Медиаплееры" },
                new TypeProduct { Id=19, Name="Умный дом" },
                new TypeProduct { Id=20, Name="Техника для уборки" },
                new TypeProduct { Id=21, Name="Транспорт" },
                new TypeProduct { Id=22, Name="Освещение" },
                new TypeProduct { Id=23, Name="Кабели" },
                new TypeProduct { Id=24, Name="Прочее" }
                });

            modelBuilder.Entity<Position>().HasData(
                new Position[]
                {
                    new Position{Id=1, Name="Administrator", AccessLevel = 5 },
                    new Position{Id=2, Name="Менеджер магазина", AccessLevel = 2 },
                    new Position{Id=3, Name="Продавец", AccessLevel = 1 }
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Admin", SecondName = "Admin", Login = "Admin", Password = "Admin", PositionId = 1 }
                );

        }
        #endregion



    }
}
