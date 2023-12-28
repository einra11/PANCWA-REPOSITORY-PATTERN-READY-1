using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheBoxApp.Data.Context;
using TheBoxApp.Data.Models;
using System.Text.Json;

namespace TheBoxApp.Data.Seeder
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<MachineDataContext>();
            context.Database.EnsureCreated();

            // Seed the database
            AddMachines(context);
        }


        private static void AddMachines(MachineDataContext context)
        {
            // Add machines
            var machine = context.Machines.FirstOrDefault();

            if (machine == null) return;


            var machineDashBoardContext = JsonSerializer.Serialize(new
            {
                timepicker = new { },
                timezone = "browser",
                version = 16,
                id = "",
            });

            context.Machines.Add(new Machine
            {
                Name = "Machine 1",
                Ip = "192.165.254.254",
                MachineDashBoardProperties = new MachineDashBoardProperties
                {
                  context = machineDashBoardContext
                }
            });

            context.Machines.Add(new Machine
            {
                Name = "Machine 1",
                Ip = "192.165.254.255",
                MachineDashBoardProperties = new MachineDashBoardProperties
                {
                    context = machineDashBoardContext
                }
            });

            context.Machines.Add(new Machine
            {
                Name = "Machine 3",
                Ip = "192.165.254.256",
                MachineDashBoardProperties = new MachineDashBoardProperties
                {
                    context = machineDashBoardContext
                }
            });

            context.SaveChanges();
        }
    }
}
