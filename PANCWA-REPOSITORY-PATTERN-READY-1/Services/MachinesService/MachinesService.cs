using PANCWA_REPOSITORY_PATTERN_READY_1.Models;
using System.Data;
using TheBoxApp.Data.Context;
using System.Text.Json;
using TheBoxApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public class MachinesService : IMachinesService
    {
        private readonly ILogger<MachinesService> _logger;
        private readonly MachineDataContext context;
        private readonly Dictionary<OS_TYPES, MachineOsGateWays> gateWays;

        public MachinesService(MachineDataContext context, ILogger<MachinesService> logger)
        {
            _logger = logger;
            this.context = context;

            gateWays = new Dictionary<OS_TYPES, MachineOsGateWays> {
                {OS_TYPES.Windows, new WindowsMachineOsGateWays() },
                {OS_TYPES.Ubuntu, new UbuntuMachineOsGateWays() },
                {OS_TYPES.Mac, new MacMachineOsGateWays() },
            };
        }
        private void DisposeMachine(int id)
        {
            throw new NotImplementedException();
        }

        private void RegisterToPrometheus(MachineViewModel machine, IDataAdapter properties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MachineViewModel> Get()
        {


            try
            {
                var machines = this.context.Machines.Select(machine => new MachineViewModel
                {
                    Name = machine.Name,
                    Ip = machine.Ip,
                });

                return machines;
            }
            catch (Exception e)
            {
                this._logger.LogError(message: e.ToString());

                return Array.Empty<MachineViewModel>();
            }

        }

        public bool Insert(MachineViewModel machine)
        {
            try
            {
                this.context.Add(new Machine
                {
                    Name = machine.Name,
                    Ip = machine.Ip,
                });

                this.context.SaveChanges();

                ImprintNotesOnOsType(OS_TYPES.Ubuntu);

                return true;
            }
            catch (Exception e)
            {

                this._logger.LogError(message: e.ToString());
                return false;
            }
        }

        public IDataAdapter Update(MachineViewModel machine)
        {
            throw new NotImplementedException();
        }

        public IDataAdapter Delete(MachineViewModel machine)
        {
            throw new NotImplementedException();
        }

        private void ImprintNotesOnOsType(OS_TYPES os)
        {
            if (gateWays.ContainsKey(os))
            {
                gateWays[os].osPlatform(os.ToString());
            }
        }   
    }

}
