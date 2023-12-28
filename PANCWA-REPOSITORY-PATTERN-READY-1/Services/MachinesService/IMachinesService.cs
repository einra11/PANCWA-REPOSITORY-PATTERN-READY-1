
using PANCWA_REPOSITORY_PATTERN_READY_1.Models;
using System.Data;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public interface IMachinesService
    {
        IEnumerable<MachineViewModel> Get();
        IDataAdapter Insert(MachineViewModel machine);
        IDataAdapter Update(MachineViewModel machine);
        IDataAdapter Delete(MachineViewModel machine);

    }
}
