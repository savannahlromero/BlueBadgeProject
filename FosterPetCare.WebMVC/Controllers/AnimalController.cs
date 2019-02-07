using FosterPetCare.Models.Animal;
using FosterPetCare.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FosterPetCare.WebMVC.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Index()
        {
            var model = new AnimalEntry[0];
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnimalCreate model)
        {
            //if (ModelState.IsValid) return View(model);
            //var service = CreateAnimalService(); // FIX
            //if (service.CreateAnimal(model))
            //{
            //    return RedirectToAction("Index");
            //};
            //return View(model);
        }
    }
}