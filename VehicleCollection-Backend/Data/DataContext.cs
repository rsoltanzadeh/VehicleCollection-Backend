using Microsoft.EntityFrameworkCore;

namespace VehicleCollection_Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
