using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Project.Config;

namespace Project.DataContext
{
    public class WoodshopContext : DbContext
    {
        private ConnectionStrings _connectionStrings;

        public WoodshopContext(DbContextOptions<WoodshopContext> options, IOptions<ConnectionStrings> connectionStrings) : base(options)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            // options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<SneakerOccasion>()
            //    .HasKey(cs => new { cs.SneakerId, cs.OccasionId });

            // modelBuilder.Entity<Brand>().HasData(new Brand()
            // {
            //     BrandId = 1,
            //     Name = "ASICS"
            // });


            // modelBuilder.Entity<Brand>().HasData(new Brand()
            // {
            //     BrandId = 2,
            //     Name = "CONVERSE"
            // });

            // modelBuilder.Entity<Brand>().HasData(new Brand()
            // {
            //     BrandId = 3,
            //     Name = "JORDAN"
            // });

            // modelBuilder.Entity<Occasion>().HasData(new Occasion()
            // {
            //     OccasionId = 1,
            //     Description = "Sports"
            // });


            // modelBuilder.Entity<Occasion>().HasData(new Occasion()
            // {
            //     OccasionId = 2,
            //     Description = "Casual"
            // });

            // modelBuilder.Entity<Occasion>().HasData(new Occasion()
            // {
            //     OccasionId = 3,
            //     Description = "Skate"
            // });
        }
    }
}
