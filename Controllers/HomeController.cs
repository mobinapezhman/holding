using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class MyValue
    {
        public string? Title { get; set; }
        public long Value { get; set; }
    }



    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RepositoryDW repository;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            repository = new RepositoryDW();
        }

        public IActionResult Index()
        {
            var model = repository.GetDataModel();
            return View(model);
        }

        [Authorize]
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