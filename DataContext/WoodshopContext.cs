using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Project.Config;
using Project.Models;

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
            modelBuilder.Entity<Customer>().HasKey(c => new { c.PersonId });
            modelBuilder.Entity<Staff>().HasKey(s => new { s.PersonId });
            modelBuilder.Entity<Product>().HasOne(p => p.Unit).WithMany(u => u.Products);


            #region Products
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Oregon 7x15",
                Thickness = 7,
                Width = 15,
                Price = 5.01,
                UnitId = 1,

            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Oregon 7x18",
                Thickness = 7,
                Width = 18,
                Price = 4.62,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Pannelatten",
                Thickness = 2.4,
                Width = 3.2,
                Price = 0.30,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Stoflatten",
                Thickness = 2,
                Width = 2.3,
                Price = 0.22,
                UnitId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "RND gedrenkt",
                Thickness = 2.5,
                Width = 10,
                Price = 0.85,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "RND ongeschaafd",
                Thickness = 2,
                Width = 10,
                Price = 0.61,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Merantiplaten",
                Thickness = 0.36,
                Width = 122,
                Price = 4.45,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "CDX platen",
                Thickness = 1.8,
                Width = 122,
                Price = 6.56,
                UnitId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "OBS platen",
                Thickness = 1.2,
                Width = 59,
                Price = 3.97,
                UnitId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Meubelplaten wit",
                Thickness = 1,
                Width = 20,
                Price = 5.62,
                UnitId = 3,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Gipsplaten",
                Thickness = 0.9,
                Width = 0,
                Price = 2.64,
                UnitId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Plafondlatten",
                Thickness = 2.2,
                Width = 4.5,
                Price = 0.57,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "CLS",
                Thickness = 3.8,
                Width = 5.8,
                Price = 0.99,
                UnitId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Terrasplanken tali",
                Thickness = 2.5,
                Width = 14.5,
                Price = 6.35,
                UnitId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Thermowood",
                Thickness = 63,
                Width = 150,
                Price = 6.15,
                UnitId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = Guid.NewGuid(),
                Name = "Tali kepers",
                Thickness = 40,
                Width = 55,
                Price = 2.81,
                UnitId = 1
            });
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
