﻿// <auto-generated />
using System;
using InveTime.DataBase.DLL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InveTime.DataBase.DLL.Migrations
{
    [DbContext(typeof(InveTimeDB))]
    partial class InveTimeDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.DateInventarisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InventarisationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DateInventarisations");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "Admin",
                            Name = "Admin",
                            Password = "Admin",
                            PositionId = 1,
                            SecondName = "Admin"
                        });
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessLevel = 5,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            AccessLevel = 2,
                            Name = "Менеджер магазина"
                        },
                        new
                        {
                            Id = 3,
                            AccessLevel = 1,
                            Name = "Продавец"
                        });
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountData")
                        .HasColumnType("int");

                    b.Property<int>("AmountFact")
                        .HasColumnType("int");

                    b.Property<int>("AmountResult")
                        .HasColumnType("int");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DateInventarisationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Peresort")
                        .HasColumnType("bit");

                    b.Property<int?>("TypeProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DateInventarisationId");

                    b.HasIndex("TypeProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.TypeProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Внешние аккумуляторы"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ноутбуки"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Рюкзаки/сумки/чемоданы"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Мобильные телефоны"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Чехлы для телефонов"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Защитные стёкла/плёнки"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Умные часы/браслеты"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ремешки для часов/браслетов"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Видеорегистраторы"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Карты памяти"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Батарейки"
                        },
                        new
                        {
                            Id = 12,
                            Name = "IP-камеры"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Мыши компьютерные"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Портативные колонки"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Гарнитуры"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Сетевое оборудование"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Телевизоры"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Медиаплееры"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Умный дом"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Техника для уборки"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Транспорт"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Освещение"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Кабели"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Прочее"
                        });
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Employee", b =>
                {
                    b.HasOne("InveTime.DataBase.DLL.Entityes.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Product", b =>
                {
                    b.HasOne("InveTime.DataBase.DLL.Entityes.DateInventarisation", "DateInventarisation")
                        .WithMany("Products")
                        .HasForeignKey("DateInventarisationId");

                    b.HasOne("InveTime.DataBase.DLL.Entityes.TypeProduct", "TypeProduct")
                        .WithMany("Products")
                        .HasForeignKey("TypeProductId");

                    b.Navigation("DateInventarisation");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.DateInventarisation", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.TypeProduct", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
