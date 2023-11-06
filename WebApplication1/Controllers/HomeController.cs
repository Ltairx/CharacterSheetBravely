using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    /*
     TODO:
        - deleting item from Items
        - de/serialize data into json (in character class) and save it on server
        - export/import json data
     */

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Character model;        // TODO multiple users at the same time, change the way character is set

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {          
            return View(model);
        }

        [HttpPost]
        public ActionResult AddItem()
        {
            model.Items.Add(" ", 0);                    // TODO change added keys/change dict for List<KeyValuePair<string, int>> or something similar
            return PartialView("ItemPartial", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}