using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUD.Models;

namespace MVCCRUD.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (DBmodel dBmodel= new DBmodel())
            return View(dBmodel.Students.ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            using (DBmodel dBmodel = new DBmodel())
            {
                return View(dBmodel.Students.Where(x => x.ID ==id).FirstOrDefault());
            }
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                using(DBmodel dBmodel=new DBmodel())
                {
                    dBmodel.Students.Add(student);
                    dBmodel.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBmodel dBmodel = new DBmodel())
            {
                return View(dBmodel.Students.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                // TODO: Add update logic here
                using (DBmodel dBmodel= new DBmodel())
                {
                    dBmodel.Entry(student).State = EntityState.Modified;
                    dBmodel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBmodel dBmodel = new DBmodel())
            {
                return View(dBmodel.Students.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using(DBmodel dBmodel= new DBmodel())
                {
                    Student student= dBmodel.Students.Where(x => x.ID == id).FirstOrDefault();
                    dBmodel.Students.Remove(student);
                    dBmodel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
