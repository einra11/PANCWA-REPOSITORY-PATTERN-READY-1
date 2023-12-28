using Microsoft.EntityFrameworkCore;
using PANCWA_REPOSITORY_PATTERN_READY_1.Models;
using System.Data;
using TheBoxApp.Data.Context;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public class MachinesService : IMachinesService
    {
        private readonly MachineDataContext context;
        public MachinesService(MachineDataContext context)
        {
            this.context = context;
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
            var machines = this.context.Machines.Select(m => new MachineViewModel
            {
                Name = m.Name,
                Ip = m.Ip,
            });

            return machines;
        }

        public IDataAdapter Insert(MachineViewModel machine)
        {
            throw new NotImplementedException();
        }

        public IDataAdapter Update(MachineViewModel machine)
        {
            throw new NotImplementedException();
        }

        public IDataAdapter Delete(MachineViewModel machine)
        {
            throw new NotImplementedException();
        }
    }
}
