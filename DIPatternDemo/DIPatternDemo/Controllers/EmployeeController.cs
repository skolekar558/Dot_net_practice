using DIPatternDemo.Models;
using DIPatternDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIPatternDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices services;
        public EmployeeController(IEmployeeServices services)
        {
            this.services = services;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var model=services.GetEmployees();
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = services.GetEmployeeById(id);
            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                int result = services.AddEmployee(emp);
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

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = services.GetEmployeeById(id);
            return View(model);

           
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                int result = services.EditEmployee(emp);
                if (result > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(emp);
                }
            }
            catch
            {
                return View(emp);
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = services.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                int result = services.DeleteEmployee(id);
                if (result > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
