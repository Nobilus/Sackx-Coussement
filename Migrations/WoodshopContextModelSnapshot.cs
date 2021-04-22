﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DataContext;

namespace Project.Migrations
{
    [DbContext(typeof(WoodshopContext))]
    partial class WoodshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Project.Models.Customer", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            CompanyNumber = "0123456789"
                        });
                });

            modelBuilder.Entity("Project.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Project.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 2,
                            FirstName = "Sander",
                            LastName = "Coussement"
                        },
                        new
                        {
                            PersonId = 1,
                            FirstName = "Jonas",
                            LastName = "De Meyer"
                        });
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Thickness")
                        .HasColumnType("float");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("d35e2f98-1f40-4aee-a880-d23d2223ec0f"),
                            Name = "Oregon 7x15",
                            Price = 5.0099999999999998,
                            Thickness = 7.0,
                            UnitId = 1,
                            Width = 15.0
                        },
                        new
                        {
                            ProductId = new Guid("c62f54e4-fe3c-4c24-ab01-0112ef2d620c"),
                            Name = "Oregon 7x18",
                            Price = 4.6200000000000001,
                            Thickness = 7.0,
                            UnitId = 1,
                            Width = 18.0
                        },
                        new
                        {
                            ProductId = new Guid("ab7129cf-be14-4550-b615-5127a9d998d6"),
                            Name = "Pannelatten",
                            Price = 0.29999999999999999,
                            Thickness = 2.3999999999999999,
                            UnitId = 1,
                            Width = 3.2000000000000002
                        },
                        new
                        {
                            ProductId = new Guid("7d21bbb5-00e6-4269-bc86-085382e58e9a"),
                            Name = "Stoflatten",
                            Price = 0.22,
                            Thickness = 2.0,
                            UnitId = 1,
                            Width = 2.2999999999999998
                        },
                        new
                        {
                            ProductId = new Guid("d4c86bc8-9809-4a29-b67e-b9f23084d712"),
                            Name = "RND gedrenkt",
                            Price = 0.84999999999999998,
                            Thickness = 2.5,
                            UnitId = 1,
                            Width = 10.0
                        },
                        new
                        {
                            ProductId = new Guid("9f6c35ee-3c15-497a-aeee-110f825fbf0c"),
                            Name = "RND ongeschaafd",
                            Price = 0.60999999999999999,
                            Thickness = 2.0,
                            UnitId = 1,
                            Width = 10.0
                        },
                        new
                        {
                            ProductId = new Guid("d55ae7cc-d7de-4a98-864a-4fac73336b7a"),
                            Name = "Merantiplaten",
                            Price = 4.4500000000000002,
                            Thickness = 0.35999999999999999,
                            UnitId = 1,
                            Width = 122.0
                        },
                        new
                        {
                            ProductId = new Guid("98ddecc3-e67d-4d89-9e1c-c3bd70871b4a"),
                            Name = "CDX platen",
                            Price = 6.5599999999999996,
                            Thickness = 1.8,
                            UnitId = 2,
                            Width = 122.0
                        },
                        new
                        {
                            ProductId = new Guid("11cc6b49-0032-47ec-81cf-bb8e35497862"),
                            Name = "OBS platen",
                            Price = 3.9700000000000002,
                            Thickness = 1.2,
                            UnitId = 2,
                            Width = 59.0
                        },
                        new
                        {
                            ProductId = new Guid("71839a16-d0ee-48df-9793-f4d448a0b70e"),
                            Name = "Meubelplaten wit",
                            Price = 5.6200000000000001,
                            Thickness = 1.0,
                            UnitId = 3,
                            Width = 20.0
                        },
                        new
                        {
                            ProductId = new Guid("49403ced-8cfe-4b98-98d6-46766384ee38"),
                            Name = "Gipsplaten",
                            Price = 2.6400000000000001,
                            Thickness = 0.90000000000000002,
                            UnitId = 2,
                            Width = 0.0
                        },
                        new
                        {
                            ProductId = new Guid("bc98bde3-9d4c-49d2-b846-5fcc7ebb57ba"),
                            Name = "Plafondlatten",
                            Price = 0.56999999999999995,
                            Thickness = 2.2000000000000002,
                            UnitId = 1,
                            Width = 4.5
                        },
                        new
                        {
                            ProductId = new Guid("c6b3b5c3-d446-4e35-9084-fa83a62eb2f2"),
                            Name = "CLS",
                            Price = 0.98999999999999999,
                            Thickness = 3.7999999999999998,
                            UnitId = 1,
                            Width = 5.7999999999999998
                        },
                        new
                        {
                            ProductId = new Guid("f5dde93d-1b03-4513-b5cd-9f4d4a666828"),
                            Name = "Terrasplanken tali",
                            Price = 6.3499999999999996,
                            Thickness = 2.5,
                            UnitId = 1,
                            Width = 14.5
                        },
                        new
                        {
                            ProductId = new Guid("b0792a04-404b-4d2d-b57c-06ac4cefc12e"),
                            Name = "Thermowood",
                            Price = 6.1500000000000004,
                            Thickness = 63.0,
                            UnitId = 1,
                            Width = 150.0
                        },
                        new
                        {
                            ProductId = new Guid("e76be890-52b3-47e7-b5c7-54eb47a724a8"),
                            Name = "Tali kepers",
                            Price = 2.8100000000000001,
                            Thickness = 40.0,
                            UnitId = 1,
                            Width = 55.0
                        });
                });

            modelBuilder.Entity("Project.Models.Staff", b =>
                {
                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            PersonId = 2,
                            IsAdmin = true,
                            TelephoneNumber = "0412345678"
                        });
                });

            modelBuilder.Entity("Project.Models.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitId");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            UnitId = 1,
                            Desc = "Lopende meter",
                            Name = "lm"
                        },
                        new
                        {
                            UnitId = 2,
                            Desc = "Vierkante meter",
                            Name = "m²"
                        },
                        new
                        {
                            UnitId = 3,
                            Desc = "Kubieke meter",
                            Name = "m³"
                        },
                        new
                        {
                            UnitId = 4,
                            Desc = "Stuk",
                            Name = "st"
                        });
                });

            modelBuilder.Entity("Project.Models.Customer", b =>
                {
                    b.HasOne("Project.Models.Person", "Person")
                        .WithOne("Customer")
                        .HasForeignKey("Project.Models.Customer", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Project.Models.Order", b =>
                {
                    b.HasOne("Project.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Project.Models.OrderProduct", b =>
                {
                    b.HasOne("Project.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.HasOne("Project.Models.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Project.Models.Staff", b =>
                {
                    b.HasOne("Project.Models.Person", "Person")
                        .WithOne("Staff")
                        .HasForeignKey("Project.Models.Staff", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Project.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Project.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Project.Models.Person", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Project.Models.Unit", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
