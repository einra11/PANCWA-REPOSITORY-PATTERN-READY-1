using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PANCWA_REPOSITORY_PATTERN_READY_1.Models;
using PANCWA_REPOSITORY_PATTERN_READY_1.Services.MachinesService;


namespace PANCWA_REPOSITORY_PATTERN_READY_1.Controllers
{

    public class MachinesController : Controller
    {


        private readonly ILogger<MachinesController> _logger;
        private readonly IMachinesService _machinesService;



        public MachinesController(ILogger<MachinesController> logger, IMachinesService machinesService)
        {
            _logger = logger;
            _machinesService = machinesService;
        }

        [HttpGet(Name = "GetAllMachines")]
        public IActionResult Index()
        {
            _logger.LogInformation("MachineRoute");
            var machines = _machinesService.Get();

            return View(machines);
        }

        [HttpGet(Name = "NewMachine")]
        public IActionResult NewMachine(MachineViewModel? machine)
        {
            _logger.LogInformation("MachineRoute");
            return View();
        }

        public IEnumerable<MachineViewModel> Post([FromBody] MachineViewModel machine)
        {
            _logger.LogInformation("MachineRoute");
            var machines = _machinesService.Insert(machine);
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Insert(MachineViewModel machine)
        {
            _logger.LogInformation("MachineRoute");
            if (ModelState.IsValid)
            {
                bool insertMachine = _machinesService.Insert(machine);

                if (!insertMachine)
                {
                    return View("NewMachine", machine);
                }

                return RedirectToAction(nameof(Index));
            }
            return View("NewMachine", machine);
        }
    }
}
