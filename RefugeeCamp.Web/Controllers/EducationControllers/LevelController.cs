using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServiceSpecifique.Services.EducationServices;
using RefugeeCamp.Web.Models.EducationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Controllers.EducationControllers
{
    public class LevelController : Controller
    {
        LevelService ls = new LevelService();

        // GET: Level
        public ActionResult Index()
        {
            var Level = ls.GetAll();

            List<LevelModel> llm = new List<LevelModel>();

            foreach (var item in Level)
            {
                llm.Add(new LevelModel
                {
                    Id = item.Id,
                    LevelName = item.LevelName,
                    Description = item.Description

                });
            }

            return View(llm);
        }

        // GET: Level/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Level/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Level/Create
        [HttpPost]
        public ActionResult Create(LevelModel lm)
        {

            Level l = new Level
            {
                LevelName = lm.LevelName,
                Description = lm.Description

            };

            ls.Add(l);
            ls.Commit();

            return RedirectToAction("Index");
        }

        // GET: Level/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Level/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LevelModel lm)
        {

            Level level = ls.GetById(id);
            level.LevelName = lm.LevelName;
            level.Description = lm.Description;
            ls.Update(level);

            ls.Commit();

            return View();
        }

        // GET: Level/Delete/5
        public ActionResult Delete(int id)
        {
            Level level = ls.GetById(id);
            ls.Delete(level);
            ls.Commit();
            return View();
        }

        // POST: Level/Delete/5
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
