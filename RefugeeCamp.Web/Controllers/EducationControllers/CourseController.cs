using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServiceSpecifique.Services.EducationServices;
using RefugeeCamp.Web.Helpers;
using RefugeeCamp.Web.Models.EducationModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Controllers.EducationControllers
{
    public class CourseController : Controller
    {
        CourseService cs = new CourseService();
        // GET: Course
        public ActionResult Index()
        {
            var Course = cs.GetAll();

            List<CourseModel> lcm = new List<CourseModel>();

            foreach (var item in Course)
            {
                lcm.Add(new CourseModel
                {
                    CourseId = item.CourseId,
                    Name = item.Name,
                    Description = item.Description,
                    level = item.level

                });
            }

            return View(lcm);

        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            //var Cou = cs.GetAll().Where(c => c.CourseId == id).First();
            //return View(Cou);
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            var cm = new CourseModel();
            cm.MLevel = cs.GetAllLevel().ToSelectListItems();

            return View(cm);
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create( CourseModel cm)
        {
            Course course = new Course
            {
                Name = cm.Name,
                Description = cm.Description,
                LevelId = cm.LevelId
                

            };
            cs.Add(course);
            cs.Commit();


            return RedirectToAction("Index");

        }
        

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            var cm = new CourseModel();
            cm.MLevel = cs.GetAllLevel().ToSelectListItems();

            return View(cm);
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CourseModel cm)
        {
            Course cour = cs.GetById(id);
            cour.Name = cm.Name;
            cour.Description = cm.Description;
            cour.LevelId = cm.LevelId;
            cs.Update(cour);

            cs.Commit();

            return RedirectToAction("Index");
         
            
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            Course cour = cs.GetById(id);
            cs.Delete(cour);
            cs.Commit();
            return View();


        }

        // POST: Course/Delete/5
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
