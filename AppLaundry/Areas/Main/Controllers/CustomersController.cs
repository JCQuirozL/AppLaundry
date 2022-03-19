using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLaundry.Areas.Main.Controllers
{
    [Area("Main")]
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
