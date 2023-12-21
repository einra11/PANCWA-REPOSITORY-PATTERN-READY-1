
using PANCWA_REPOSITORY_PATTERN_READY_1.Models;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public interface IMachinesService
    {
        IEnumerable<Machine> Get();
    }
}
