using H2Pros.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H2Pros.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Consumption> consumptions { get; set; }


        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public UserContext()
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasMany(a => a.consumptions)
            //    .WithOne().HasForeignKey(b => b.cpr)
            //    .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=H2ProsDB;User ID=postgres;Password=123;Pooling=true;");
        //}
    }
}
