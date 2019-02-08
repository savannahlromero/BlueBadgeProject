using FosterPetCare.Models.Caretaker;
using FosterPetCare.Services;
using FosterPetCare.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FosterPetCare.WebMVC.Controllers
{
    public class CaretakerController : Controller
    {
        // GET: Caretaker
        public ActionResult Index()
        {
            var service = new CaretakerService();
            var model = service.GetCaretakers;
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
        public ActionResult Create(CaretakerCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = new CaretakerService();
            if (service.CreateCaretaker(model))
            {
                TempData["SaveResult"] = "Your Caretaker Entry was created.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Caretaker Entry could not be created.");
            return View(model);
        }
        // GET: Details
        public ActionResult Details(int id)
        {
            var service = new CaretakerService();
            var model = service.GetCaretakerByID(id);

            return View(model);
        }
    }
}