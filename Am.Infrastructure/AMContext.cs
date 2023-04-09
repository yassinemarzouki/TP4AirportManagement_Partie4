using Am.Infrastructure.Configuration;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Infrastructure
{
    public class AMContext : DbContext
    {

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<plane> planes { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
        Initial Catalog=OussamaLachihebDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        {
            modelConfigurationBuilder.
                Properties<DateTime>().
                HaveColumnType("date");
        }
    }
}
