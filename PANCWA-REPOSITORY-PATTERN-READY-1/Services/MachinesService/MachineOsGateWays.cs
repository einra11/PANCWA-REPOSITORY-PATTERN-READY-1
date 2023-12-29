using System.Runtime.InteropServices;

namespace PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService
{
    public abstract class MachineOsGateWays
    {
        public abstract void osPlatform(string os);
    }

    public class UbuntuMachineOsGateWays : MachineOsGateWays
    {
        public override void osPlatform(string os)
        {
            //CREATE OS NOTE FOR SPECIFIC OS PLATFORM
            Console.WriteLine(os);
        }
    }

    public class WindowsMachineOsGateWays : MachineOsGateWays
    {
        public override void osPlatform(string os)
        {
            //CREATE OS NOTE FOR SPECIFIC OS PLATFORM
            Console.WriteLine(os);
        }
    }

    public class MacMachineOsGateWays : MachineOsGateWays
    {
        public override void osPlatform(string os)
        {
            //CREATE OS NOTE FOR SPECIFIC OS PLATFORM
            Console.WriteLine(os);
        }
    }


    enum OS_TYPES
    {
        Windows,
        Ubuntu,
        Mac
    }
}
