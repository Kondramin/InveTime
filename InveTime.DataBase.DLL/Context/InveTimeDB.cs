using InveTime.DataBase.DLL.Entityes;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace InveTime.DataBase.DLL.Context
{
    public class InveTimeDB : DbContext
    {


        #region Entityes


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<DateInventarisation> DateInventarisations { get; set; }


        #endregion


        public InveTimeDB([NotNullAttribute] DbContextOptions options) : base(options) { }



        #region Initial Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeProduct>().HasData(
                new TypeProduct[]
                {
                new TypeProduct { Id=1, Name="Внешний аккумулятор" },
                new TypeProduct { Id=2, Name="Ноутбук" },
                new TypeProduct { Id=3, Name="Рюкзак/сумка/чемодан" },
                new TypeProduct { Id=4, Name="Мобильный телефон" },
                new TypeProduct { Id=5, Name="Чехол/бампер для телефона" },
                new TypeProduct { Id=6, Name="Защитное стёкло/плёнка" },
                new TypeProduct { Id=7, Name="Умные часы/браслет" },
                new TypeProduct { Id=8, Name="Ремешок для часов/браслета" },
                new TypeProduct { Id=9, Name="Видеорегистратор" },
                new TypeProduct { Id=10, Name="Карта памяти" },
                new TypeProduct { Id=11, Name="Батарейка" },
                new TypeProduct { Id=12, Name="IP-камера" },
                new TypeProduct { Id=13, Name="Мышь компьютерная" },
                new TypeProduct { Id=14, Name="Портативная колонка" },
                new TypeProduct { Id=15, Name="Гарнитура" },
                new TypeProduct { Id=16, Name="Сетевое оборудование" },
                new TypeProduct { Id=17, Name="Телевизор" },
                new TypeProduct { Id=18, Name="Медиаплеер" },
                new TypeProduct { Id=19, Name="Умный дом" },
                new TypeProduct { Id=20, Name="Техника для уборки" },
                new TypeProduct { Id=21, Name="Транспорт" },
                new TypeProduct { Id=22, Name="Освещение" },
                new TypeProduct { Id=23, Name="Кабель" },
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
