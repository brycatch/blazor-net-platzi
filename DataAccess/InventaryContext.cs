using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                IConfigurationRoot configuration =
                    new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json")
                    .Build();

                options.UseSqlServer(configuration.GetConnectionString("Local"));
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CategoryEntity>().HasData(
                    new CategoryEntity() { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                    new CategoryEntity() { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                    new CategoryEntity() { CategoryId = "HGR", CategoryName = "Hogar" },
                    new CategoryEntity() { CategoryId = "PRF", CategoryName = "Perfumería" }
                );

            builder.Entity<WarehouseEntity>().HasData(
                    new WarehouseEntity() { WarehouseId = Guid.NewGuid().ToString(), Address = "Dirección", WarehouseName = "Nombre" },
                    new WarehouseEntity() { WarehouseId = Guid.NewGuid().ToString(), Address = "Norte", WarehouseName = "Nombre" }
                );
        }
    }
}
