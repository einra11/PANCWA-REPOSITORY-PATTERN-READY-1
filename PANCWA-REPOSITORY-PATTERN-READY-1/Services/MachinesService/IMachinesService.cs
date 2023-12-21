
using PANCWA_REPOSITORY_PATTERN_READY_1.Models;
using System.Data;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public interface IMachinesService
    {
        IEnumerable<Machine> Get();
        IDataAdapter Insert(Machine machine);
        IDataAdapter Update(Machine machine);
        IDataAdapter Delete(Machine machine);

    }
}
