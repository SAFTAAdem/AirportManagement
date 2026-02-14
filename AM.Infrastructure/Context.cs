using Microsoft.EntityFrameworkCore;
using AM.ApplicationCore.Domain;

namespace AM.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationHelper.GetConnectionString("DefaultConnection"));
        }
    }
}