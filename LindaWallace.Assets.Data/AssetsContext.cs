using LindaWallace.Assets.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LindaWallace.Assets.Data
{
    public class AssetsContext : DbContext
    {
        public AssetsContext() : base() { }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=AssetTracking; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asset>().HasData(
               new Asset
               {
                   Id = 1,
                   TagNumber = "456",
                   AssetTypeId = 1,
                   Manufacturer = "Dell",
                   Model = "Gold Plated",
                   Description = "Joe's Home Computer",
                   SerialNumber = "8765487"
               },

                 new Asset
                 {
                     Id = 2,
                     TagNumber = "628",
                     AssetTypeId = 3,
                     Manufacturer = "Dell",
                     Model = "Basic",
                     Description = "Catalog type description can be typed here",
                     SerialNumber = "8765487"
                 },

                 new Asset
                 {
                     Id = 3,
                     TagNumber = "248",
                     AssetTypeId = 2,
                     Manufacturer = "HP",
                     Description = "Best Monitor",
                     SerialNumber = "8765487"
                 },

                 new Asset
                 {
                     Id = 4,
                     TagNumber = "963",
                     AssetTypeId = 1,
                     Manufacturer = "Acer",
                     Description = "Joe's Work Computer",
                     SerialNumber = "8765487"
                 }
               );

            modelBuilder.Entity<AssetType>().HasData(
                new AssetType
                {
                    Id = 1,
                    Name = "desktopComputer"
                },

                new AssetType
                {
                    Id = 2,
                    Name = "computerMonitor"
                },

                new AssetType
                {
                    Id = 3,
                    Name = "phone"
                }

                );
        }

    }
}
