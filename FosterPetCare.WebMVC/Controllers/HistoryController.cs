using FosterPetCare.Models.History;
using FosterPetCare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FosterPetCare.WebMVC.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult Index()
        {
            var service = new HistoryService();
            var model = service.GetHistories();
            return View(model);
        }
        // GET: Create
        public ActionResult Create()
        {
            var animalService = new AnimalService();
            var caretakerService = new CaretakerService();
            var animalList = animalService.GetAnimals();
            var caretakerList = caretakerService.GetCaretakers();

            ViewBag.AnimalID = new SelectList(animalList, "AnimalID", "AnimalName");
            ViewBag.CaretakerID = new SelectList(caretakerList, "CaretakerID", "CaretakerName");
            return View();
        }
        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HistoryCreate model)
        {
            var service = new HistoryService();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (service.CreateHistory(model))
            {
                TempData["SaveResult"] = "Your History Entry was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "History Entry could not be created.");
            return View(model);

        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var service = new HistoryService();
            var model = service.GetHistoryByID(id);

            return View(model);
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var animalService = new AnimalService();
            var caretakerService = new CaretakerService();
            var animalList = animalService.GetAnimals();
            var caretakerList = caretakerService.GetCaretakers();

            ViewBag.AnimalID = new SelectList(animalList, "AnimalID", "AnimalName");
            ViewBag.CaretakerID = new SelectList(caretakerList, "CaretakerID", "CaretakerName");

            var service = new HistoryService();
            var detail = service.GetHistoryByID(id);
            var model =
                new HistoryEdit
                {
                    HistoryID = detail.HistoryID,
                    AnimalID = detail.AnimalID,
                    CaretakerID = detail.CaretakerID,
                    AnimalName = detail.AnimalName,
                    CaretakerName = detail.CaretakerName,
                    HistoryCareType = detail.HistoryCareType,
                    DateOfCareStart = detail.DateOfCareStart
                };
            return View(model);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HistoryEdit model)
        {
            
            var animalService = new AnimalService();
            var caretakerService = new CaretakerService();
            var animalList = animalService.GetAnimals();
            var caretakerList = caretakerService.GetCaretakers();

            ViewBag.AnimalID = new SelectList(animalList, "AnimalID", "AnimalName");
            ViewBag.CaretakerID = new SelectList(caretakerList, "CaretakerID", "CaretakerName");

            if (!ModelState.IsValid) return View(model);

            if (model.HistoryID != id)
            {
                ModelState.AddModelError("", "ID Mismatch");
                return View(model);
            }
            var service = new HistoryService();

            if (service.UpdateHistory(model))
            {
                TempData["SaveResult"] = "Your History Entry was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your History Entry could not be updated.");
            return View();
        }
        // GET: Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = new HistoryService();
            var model = service.GetHistoryByID(id);

            return View(model);
        }

        // POST: Delete
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = new HistoryService();

            service.DeleteHistory(id);

            TempData["SaveResult"] = "Your History Entry was deleted.";

            return RedirectToAction("Index");
        }
    }
}