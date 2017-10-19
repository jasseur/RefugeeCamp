using RefugeeCamp.Service.ServiceSpecifique.Services;
using RefugeeCamp.Web.Models.HealthcareModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Controllers.HealthcareControllers
{
    public class PerscriptionController : Controller
    {
        // GET: Perscription
        public ActionResult Index()
        {
            return View();
        }

        // GET: Perscription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Perscription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perscription/Create
        [HttpPost]
        public ActionResult Create(PerscriptionModel perscriptionModel)
        {
            PrescriptionService prescriptionService = new PrescriptionService();

            prescriptionService.Add(perscriptionModel);
            return View();
        }

        // GET: Perscription/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Perscription/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Perscription/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Perscription/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
