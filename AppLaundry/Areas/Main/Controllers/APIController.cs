using DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLaundry.Areas.Main.Controllers
{
    [Area("Main")]
    public class APIController : Controller
    {
        
        public IWorkUnity WorkUnity { get; set; }
        public APIController(IWorkUnity workUnity)
        {
            WorkUnity = workUnity;
        }
        public IActionResult GetCustomerList()
        {
            return Json(new { data = WorkUnity.CustomerRepo.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            WorkUnity.CustomerRepo.Remove(id);
            WorkUnity.Save();

            return Json(new { success = true, message = "Registro borrado." });
        }
    }
}
