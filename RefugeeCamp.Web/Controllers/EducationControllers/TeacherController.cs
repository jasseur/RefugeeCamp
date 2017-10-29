using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServiceSpecifique.Services.EducationServices;
using RefugeeCamp.Web.Models.EducationModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Controllers.EducationControllers
{
    public class TeacherController : Controller
    {
        TeacherService ts = new TeacherService();
        List<TeacherModel> ltm = new List<TeacherModel>();

        // GET: Teacher
        public ActionResult Index()
        {
            var Teacher = ts.GetAll();

            List<TeacherModel> ltm = new List<TeacherModel>();

            foreach (var item in Teacher)
            {
                ltm.Add(new TeacherModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BirthDate = item.BirthDate,
                    HireDate = item.HireDate,
                    Gender = item.Gender,
                    Contact = item.Contact,
                    Role = item.Role,
                    TeachingField = item.TeachingField,
                    Notes = item.Notes

                });
            }

            return View(ltm);
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            Response.Write("dddd: " + id + "</h1>");
            
            return View();
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        public ActionResult Create(TeacherModel tm)
        {

            Teacher t = new Teacher
            {
                FirstName = tm.FirstName,
                LastName = tm.LastName,
                BirthDate = tm.BirthDate,
                HireDate = tm.HireDate,
                Gender = tm.Gender,
                Contact = tm.Contact,
                Role = tm.Role,
                TeachingField = tm.TeachingField,
                Notes = tm.Notes

            };

            ts.Add(t);
            ts.Commit();

            return RedirectToAction("Index");

        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TeacherModel tm)
        {
            Teacher teacher = ts.GetById(id);
            teacher.FirstName = tm.FirstName;
            teacher.LastName = tm.LastName;
            teacher.BirthDate = tm.BirthDate;
            teacher.HireDate = tm.HireDate;
            teacher.Gender = tm.Gender;
            teacher.Contact = tm.Contact;
            teacher.Role = tm.Role;
            teacher.TeachingField = tm.TeachingField;
            teacher.Notes = tm.Notes;
            ts.Update(teacher);

            ts.Commit();

            return View();
            
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {
            Teacher teacher = ts.GetById(id);
            ts.Delete(teacher);
            ts.Commit();

            return View();
        }

        // POST: Teacher/Delete/5
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


        public ActionResult TeachersCount()
        {
            testTeacherModel tm = new testTeacherModel();
            tm.n = ts.GetCountteachers();
            return View(tm);
        }








    }
}
