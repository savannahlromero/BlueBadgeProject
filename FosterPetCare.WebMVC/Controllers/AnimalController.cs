using FosterPetCare.Models.Animal;
using FosterPetCare.Services;
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
            var service = new AnimalService();
            var model = service.GetAnimals();
            return View(model);
        }
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnimalCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = new AnimalService();

            if (service.CreateAnimal(model))
            {
                TempData["SaveResult"] = "Your Animal Entry was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Animal Entry could not be created.");
            return View(model);

        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var service = new AnimalService();
            var model = service.GetAnimalById(id);

            return View(model);
        }
    }
}