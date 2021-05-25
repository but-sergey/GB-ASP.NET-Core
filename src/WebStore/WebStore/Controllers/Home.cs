using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Controllers
{
    //[Controller]
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;

        public HomeController(IConfiguration Configuration)
        { 
            _Configuration = Configuration;
        }

        public IActionResult Index()
        {
            return Content("Hello from controller!!!");
        }

        public IActionResult SecondAction()
        {
            return Content(_Configuration["Greetings"]);
        }
    }
}
