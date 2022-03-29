#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp2.Models;

namespace WebApp2.Data
{
    public class Inventory : DbContext
    {
        public Inventory (DbContextOptions<Inventory> options)
            : base(options)
        {
        }

        public DbSet<Chemical> Chemicals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chemical>().ToTable("Chemical");
        }
    }
}
