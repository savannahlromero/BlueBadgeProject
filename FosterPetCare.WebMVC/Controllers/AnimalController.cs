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
    }
}