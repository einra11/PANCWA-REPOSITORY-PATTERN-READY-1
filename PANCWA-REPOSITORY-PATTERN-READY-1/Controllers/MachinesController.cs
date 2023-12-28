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
    }
}
