using System.Globalization;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Project.Config;
using Project.Models;
using System.IO;
using CsvHelper;
using Project.DTO;
using Woodshop.API.Models;

namespace Project.DataContext
{

    public interface IWoodshopContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Unit> Units { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Staff> Staff { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }
        DbSet<ProductGroup> ProductGroups { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class WoodshopContext : DbContext, IWoodshopContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }

        private ConnectionStrings _connectionStrings;

        public WoodshopContext(DbContextOptions<WoodshopContext> options, IOptions<ConnectionStrings> connectionStrings) : base(options)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Customer>()
            .HasKey(c => new { c.CustomerId });

            modelBuilder.Entity<Staff>()
            .HasKey(s => new { s.PersonId });

            modelBuilder.Entity<Order>()
            .HasOne<Customer>(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId);


            modelBuilder.Entity<Product>()
            .HasOne(p => p.Unit)
            .WithMany(u => u.Products);

            modelBuilder.Entity<ProductGroup>()
            .HasMany(pg => pg.Products)
            .WithOne(p => p.ProductGroup);


            modelBuilder.Entity<OrderProduct>()
            .HasKey(op => new { op.OrderId, op.ProductId });


            #region Staff
            modelBuilder.Entity<Person>().HasData(new Person()
            {
                PersonId = 2,
                FirstName = "Sander",
                LastName = "Coussement"
            });
            modelBuilder.Entity<Staff>().HasData(new Staff()
            {
                PersonId = 2,
                TelephoneNumber = "0412345678",
                IsAdmin = true,
            });

            modelBuilder.Entity<ProductGroup>().HasData(new ProductGroup()
            {
                ProductGroupId = 1,
                ProductGroupName = "Alle"
            });
            #endregion
            #region Customers
            using (StreamReader reader = new StreamReader("SeedData/klanten.csv"))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                IEnumerable<CustomerAddDTO> customers = csv.GetRecords<CustomerAddDTO>();
                foreach (CustomerAddDTO c in customers)
                {
                    modelBuilder.Entity<Customer>().HasData(new Customer()
                    {
                        CustomerId = Guid.NewGuid(),
                        CustomerName = c.CustomerName,
                        FirstName = c.FirstName,
                        Street = c.Street,
                        Postal = c.Postal,
                        City = c.City,
                    });
                }
            }

            #endregion
            #region Products

            using (StreamReader reader = new StreamReader("SeedData/producten.csv"))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                IEnumerable<ProductAddDTO> products = csv.GetRecords<ProductAddDTO>();
                foreach (ProductAddDTO p in products)
                {
                    modelBuilder.Entity<Product>().HasData(new Product()
                    {
                        ProductId = Guid.NewGuid(),
                        Name = p.Name,
                        Thickness = p.Thickness,
                        Width = p.Width,
                        Price = p.Price,
                        PurchasePrice = p.PurchasePrice,
                        UnitId = p.UnitId,
                        ProductGroupId = 1,
                    });
                }
            }

            #endregion
            #region Units
            modelBuilder.Entity<Unit>().HasData(new Unit()
            {
                UnitId = 1,
                Name = "lm",
                Desc = "Lopende meter",
            });
            modelBuilder.Entity<Unit>().HasData(new Unit()
            {
                UnitId = 2,
                Name = "m²",
                Desc = "Vierkante meter",
            });
            modelBuilder.Entity<Unit>().HasData(new Unit()
            {
                UnitId = 3,
                Name = "m³",
                Desc = "Kubieke meter",
            });
            modelBuilder.Entity<Unit>().HasData(new Unit()
            {
                UnitId = 4,
                Name = "st",
                Desc = "Stuk",
            });
            #endregion

        }
    }
}
