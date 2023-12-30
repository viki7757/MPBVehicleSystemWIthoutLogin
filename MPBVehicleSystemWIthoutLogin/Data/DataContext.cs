using Microsoft.EntityFrameworkCore;
using MPBVehicleSystemWIthoutLogin.Shared.Entities;

namespace MPBVehicleSystemWIthoutLogin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<VehicleDetails> VehicleDetails { get; set; }
    }
}
