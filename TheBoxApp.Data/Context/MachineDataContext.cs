using Microsoft.EntityFrameworkCore;
using TheBoxApp.Data.Models;

namespace TheBoxApp.Data.Context
{
    public class MachineDataContext : DbContext
    {
        public MachineDataContext(DbContextOptions<MachineDataContext> options): 
            base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineDashBoardProperties> DashBoardProperties { get; set; }
    }
}
