using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using TaskSchedule.Helper;
using TaskSchedule.Models;

namespace TaskSchedule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Schedule schedule = new Schedule();
            var tasks = ScheduleHelper.AssignToEmployee().OrderBy(x => x.Day);
            schedule.FirstDay = tasks.Where(x => x.Day == 1).OrderBy(y => y.Employee.Name).ToList();
            schedule.SecondDay = tasks.Where(x => x.Day == 2).OrderBy(y => y.Employee.Name).ToList();
            schedule.ThirdDay = tasks.Where(x => x.Day == 3).OrderBy(y => y.Employee.Name).ToList();
            schedule.FourthDay = tasks.Where(x => x.Day == 4).OrderBy(y => y.Employee.Name).ToList();
            schedule.FifthDay = tasks.Where(x => x.Day == 5).OrderBy(y => y.Employee.Name).ToList();

            return View(schedule);
        }



        public IActionResult Privacy()
        {
            return View();
        }


    }
}


