using CodeFirstDemo.Data;
using CodeFirstDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var emp=context.Employee.ToList();
            return View(emp);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                context.Employee.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var emp = context.Employee.SingleOrDefault(e => e.Id == id);
            var result = new Employee()
            {
                Name = emp.Name,
                Salary =emp.Salary
        };
            return View(result);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee model)
        {
            var emp = new Employee()
            {
                Id = model.Id,
                Name = model.Name,
            };
            context.Employee.Update(emp);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        
        public ActionResult Delete(int id)
        {
            var emp=context.Employee.SingleOrDefault(e=>e.Id==id);
            if (emp == null)
            {
                return NotFound();
            }
            context.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
