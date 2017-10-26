using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServiceSpecifique.Services.EducationServices;
using RefugeeCamp.Web.Helpers;
using RefugeeCamp.Web.Models.EducationModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Controllers.EducationControllers
{
    public class StudentController : Controller
    {
        StudentService ss = new StudentService();

        // GET: Student
        public ActionResult Index()
        {
            
            var Student = ss.GetAll();

            List<StudentModel> lsm = new List<StudentModel>();

            foreach (var item in Student)
            {
                lsm.Add(new StudentModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    MaritalStatus = item.MaritalStatus,
                    BirthDate = item.BirthDate,
                    RegistrationDate = item.RegistrationDate,
                    level = item.level,
                    Notes = item.Notes
                    

                });
            }

            return View(lsm);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            var sm = new StudentModel();
            sm.MLevel = ss.GetAllLevel().ToSelectListItems();

            return View(sm);
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentModel sm)
        {

            Student s = new Student
            {
          
                FirstName = sm.FirstName,
                LastName = sm.LastName,
                MaritalStatus = sm.MaritalStatus,
                BirthDate= sm.BirthDate,
                RegistrationDate = sm.RegistrationDate,
                LevelId = sm.LevelId,
                Notes = sm.Notes

            };

            ss.Add(s);
            ss.Commit();

            return RedirectToAction("Index");
            
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var sm = new StudentModel();
            sm.MLevel = ss.GetAllLevel().ToSelectListItems();

            return View(sm);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudentModel sm)
        {
            Student student = ss.GetById(id);
            student.FirstName = sm.FirstName;
            student.LastName = sm.LastName;
            student.BirthDate = sm.BirthDate;
            student.RegistrationDate = sm.RegistrationDate;
            student.LevelId = sm.LevelId;
            student.Notes = sm.Notes;

            ss.Update(student);
            ss.Commit();

            return RedirectToAction("Index");
            
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = ss.GetById(id);
            ss.Delete(student);
            ss.Commit();
            return View();
        }

        // POST: Student/Delete/5
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
