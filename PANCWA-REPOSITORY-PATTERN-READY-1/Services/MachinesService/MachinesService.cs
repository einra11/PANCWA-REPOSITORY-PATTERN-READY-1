using PANCWA_REPOSITORY_PATTERN_READY_1.Models;
using System.Data;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public class MachinesService : IMachinesService
    {

        private void DisposeMachine(int id)
        {
            throw new NotImplementedException();
        }

        private void RegisterToPrometheus(Machine machine, IDataAdapter properties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Machine> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Machine
            {
                Id = index,
                Name = "Machine " + index,
                Description = "Description " + index,
                Ip = "192.168.0." + index,
                Mac = "00:00:00:00:00:0" + index,
                Type = "Type " + index,
                Location = "Location " + index,
                Status = "Status " + index,
            })
            .ToArray();
        }

        public IDataAdapter Insert(Machine machine)
        {
            throw new NotImplementedException();
        }

        public IDataAdapter Update(Machine machine)
        {
            throw new NotImplementedException();
        }

        public IDataAdapter Delete(Machine machine)
        {
            throw new NotImplementedException();
        }
    }
}
