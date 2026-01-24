using CRUDUsingADO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDUsingADO.Controllers
{
    public class StudentController : Controller
    {
        StudentDAL sdal;
        private readonly IConfiguration configuration;

        public StudentController(IConfiguration configuration)
        {
            this.configuration = configuration;
            sdal = new StudentDAL(configuration);
        }


        // GET: StudentController
        public ActionResult Index()
        {
            var model = sdal.GetStudents();
            return View(model);
           
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var stud = sdal.GetstudById(id);
            return View(stud);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student stud)
        {
            try { 


                int result = sdal.AddStudent(stud);
            if (result >= 1)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.ErrorMsg = "Something Went Wrong";
                return View();
            }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var stud = sdal.GetstudById(id);
            return View(stud);
           
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student stud)
        {
            try
            {
                int result = sdal.EditStudent(stud);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMsg = "Something Went Wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var stud = sdal.GetstudById(id);
            return View(stud);
            
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")] 
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = sdal.DeleteStud(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMsg = "Something Went Wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }
    }
}
