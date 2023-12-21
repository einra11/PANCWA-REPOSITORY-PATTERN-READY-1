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
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet(Name = "GetAllMachines")]
        public IEnumerable<Machine> GetAll()
        {
            _logger.LogInformation("MachineRoute");
            return _machinesService.Get();
        }
    }
}
