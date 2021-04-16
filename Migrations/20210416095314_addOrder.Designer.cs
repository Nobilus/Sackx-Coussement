﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.DataContext;

namespace Project.Migrations
{
    [DbContext(typeof(WoodshopContext))]
    [Migration("20210416095314_addOrder")]
    partial class addOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project.Models.Customer", b =>
                {
                    b.Property<int?>("PersonId")
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

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = new Guid("7fa67b1d-9434-44aa-ab7c-c0815cc47963"),
                            Amount = 21.0,
                            CustomerId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Project.Models.OrderCustomer", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderCustomers");
                });

            modelBuilder.Entity("Project.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            ProductId = new Guid("49db23d0-addf-49ff-84ec-76f63d6e9de6"),
                            Name = "Oregon 7x15",
                            Price = 5.0099999999999998,
                            Thickness = 7.0,
                            UnitId = 1,
                            Width = 15.0
                        },
                        new
                        {
                            ProductId = new Guid("f2864db7-a3fd-4aa9-b4e3-4cf25fa50e64"),
                            Name = "Oregon 7x18",
                            Price = 4.6200000000000001,
                            Thickness = 7.0,
                            UnitId = 1,
                            Width = 18.0
                        },
                        new
                        {
                            ProductId = new Guid("a913fc75-f592-4188-9cc4-03b156b02837"),
                            Name = "Pannelatten",
                            Price = 0.29999999999999999,
                            Thickness = 2.3999999999999999,
                            UnitId = 1,
                            Width = 3.2000000000000002
                        },
                        new
                        {
                            ProductId = new Guid("6368d486-2bef-4c52-9cef-c6f93734cc15"),
                            Name = "Stoflatten",
                            Price = 0.22,
                            Thickness = 2.0,
                            UnitId = 1,
                            Width = 2.2999999999999998
                        },
                        new
                        {
                            ProductId = new Guid("6d7e74b5-4968-4ad3-b38a-ec36c3063f7a"),
                            Name = "RND gedrenkt",
                            Price = 0.84999999999999998,
                            Thickness = 2.5,
                            UnitId = 1,
                            Width = 10.0
                        },
                        new
                        {
                            ProductId = new Guid("e3506a8a-53da-43e2-adc2-6da626c1bd55"),
                            Name = "RND ongeschaafd",
                            Price = 0.60999999999999999,
                            Thickness = 2.0,
                            UnitId = 1,
                            Width = 10.0
                        },
                        new
                        {
                            ProductId = new Guid("398997b6-a769-4b13-ab9b-4f7f93e85a64"),
                            Name = "Merantiplaten",
                            Price = 4.4500000000000002,
                            Thickness = 0.35999999999999999,
                            UnitId = 1,
                            Width = 122.0
                        },
                        new
                        {
                            ProductId = new Guid("38c8733a-976e-469e-b3dd-064933872de4"),
                            Name = "CDX platen",
                            Price = 6.5599999999999996,
                            Thickness = 1.8,
                            UnitId = 2,
                            Width = 122.0
                        },
                        new
                        {
                            ProductId = new Guid("3d38a604-0321-4914-a7b0-02c5ffa8fa55"),
                            Name = "OBS platen",
                            Price = 3.9700000000000002,
                            Thickness = 1.2,
                            UnitId = 2,
                            Width = 59.0
                        },
                        new
                        {
                            ProductId = new Guid("e7677448-aefe-4450-a60a-9b718f8971f4"),
                            Name = "Meubelplaten wit",
                            Price = 5.6200000000000001,
                            Thickness = 1.0,
                            UnitId = 3,
                            Width = 20.0
                        },
                        new
                        {
                            ProductId = new Guid("af013445-ec70-444e-8cc6-c143a276aa42"),
                            Name = "Gipsplaten",
                            Price = 2.6400000000000001,
                            Thickness = 0.90000000000000002,
                            UnitId = 2,
                            Width = 0.0
                        },
                        new
                        {
                            ProductId = new Guid("faa9937b-00a1-4582-a7de-8756c1bb1b83"),
                            Name = "Plafondlatten",
                            Price = 0.56999999999999995,
                            Thickness = 2.2000000000000002,
                            UnitId = 1,
                            Width = 4.5
                        },
                        new
                        {
                            ProductId = new Guid("f0b0f3f9-bb94-4194-9a2b-cfb8dd8bee10"),
                            Name = "CLS",
                            Price = 0.98999999999999999,
                            Thickness = 3.7999999999999998,
                            UnitId = 1,
                            Width = 5.7999999999999998
                        },
                        new
                        {
                            ProductId = new Guid("e6423530-0f13-4bfe-97de-e7119950f93a"),
                            Name = "Terrasplanken tali",
                            Price = 6.3499999999999996,
                            Thickness = 2.5,
                            UnitId = 1,
                            Width = 14.5
                        },
                        new
                        {
                            ProductId = new Guid("003b540d-bfa5-444f-baef-c22677cdf443"),
                            Name = "Thermowood",
                            Price = 6.1500000000000004,
                            Thickness = 63.0,
                            UnitId = 1,
                            Width = 150.0
                        },
                        new
                        {
                            ProductId = new Guid("f50c235c-537f-4ccb-a686-b01c2b794489"),
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
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Product", null)
                        .WithMany("Orders")
                        .HasForeignKey("ProductId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Project.Models.OrderCustomer", b =>
                {
                    b.HasOne("Project.Models.Customer", "customer")
                        .WithMany("OrderCustomer")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Models.Order", "Order")
                        .WithMany("OrderCustomer")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("Order");
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
                    b.Navigation("OrderCustomer");
                });

            modelBuilder.Entity("Project.Models.Order", b =>
                {
                    b.Navigation("OrderCustomer");
                });

            modelBuilder.Entity("Project.Models.Person", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Project.Models.Unit", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
