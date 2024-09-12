using Microsoft.AspNetCore.Mvc;
using RESProject.Presentation.Models;
using RESProject.Repositories.Entities;
using RESProject.Repositories.Entities.AddressRepo;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RESProject.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryRealES IRepositoryRealES;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
             await IRepositoryRealES.GetById("123");
            return Ok();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
