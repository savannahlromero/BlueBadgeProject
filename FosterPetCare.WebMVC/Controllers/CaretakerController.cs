using FosterPetCare.Models.Caretaker;
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
            var model = new CaretakerEntry[0];
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CaretakerCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}