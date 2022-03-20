using AppLaundry.Models;
using DataAccess.Repository.Interfaces;
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
        public IWorkUnity WorkUnity { get; set; }
        public CustomersController(IWorkUnity workUnity)
        {
            WorkUnity = workUnity;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer model)
        {
            if (model == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                WorkUnity.CustomerRepo.Add(model);
                WorkUnity.Save();
                return RedirectToAction("Index");
            }
           
            return View(model);
        }

        public IActionResult Edit(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Customer customer = WorkUnity.CustomerRepo.Get(id);
           
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer model)
        {
            if (model== null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                WorkUnity.CustomerRepo.Update(model);
                WorkUnity.Save();
                return RedirectToAction("Index");
            }
            
            
                return View(model);
            

            
        }
    }   
}
