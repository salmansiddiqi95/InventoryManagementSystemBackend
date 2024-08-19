using System;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Models;
using System.Collections.Generic;

namespace InventoryManagementSystem.Data
{
	public class InventoryDBContext : DbContext
	{
        public InventoryDBContext(DbContextOptions<InventoryDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}

