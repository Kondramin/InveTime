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

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

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
                            Name = "Чехлы/бампера/книги для телефона"
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
                            Name = "Портативная аккустика"
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

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.CategorySearching", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoriesSearching");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "внешний"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "ноутбук"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "рюкзак"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Name = "сумка"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Name = "чемодан"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Name = "телефон"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            Name = "чехол"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            Name = "бампер"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            Name = "книга"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            Name = "стекло"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 6,
                            Name = "пленка"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 7,
                            Name = "браслет"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 7,
                            Name = "часы"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 8,
                            Name = "ремешок"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 9,
                            Name = "видеорегистратор"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 10,
                            Name = "памяти"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 11,
                            Name = "батар"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 12,
                            Name = "IP"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 13,
                            Name = "мышь"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 14,
                            Name = "колонка"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 15,
                            Name = "гарнитура"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 16,
                            Name = "Wi-Fi"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 17,
                            Name = "телевизор"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 18,
                            Name = "TV"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 19,
                            Name = "блок"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 19,
                            Name = "кнопка"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 19,
                            Name = "датчик"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 20,
                            Name = "пылесос"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 20,
                            Name = "швабра"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 21,
                            Name = "самокат"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 21,
                            Name = "велосипед"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 21,
                            Name = "гироскутер"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 22,
                            Name = "лампа"
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 23,
                            Name = "кабель"
                        });
                });

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

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("VendorCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DateInventarisationId");

                    b.HasIndex("TypeProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.CategorySearching", b =>
                {
                    b.HasOne("InveTime.DataBase.DLL.Entityes.Category", "Category")
                        .WithMany("CategoriesSearching")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
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

                    b.HasOne("InveTime.DataBase.DLL.Entityes.Category", "TypeProduct")
                        .WithMany("Products")
                        .HasForeignKey("TypeProductId");

                    b.Navigation("DateInventarisation");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Category", b =>
                {
                    b.Navigation("CategoriesSearching");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.DateInventarisation", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InveTime.DataBase.DLL.Entityes.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
