using EFDemo.Data;
using EFDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDemo.Controllers
{
    
    public class ProductController : Controller
    {
        private ApplicationDBContext db;
        ProductDAL dal;
        public ProductController(ApplicationDBContext db)
        {
            this.db = db;
            dal = new ProductDAL(this.db);
        }
            // GET: ProductController
            public ActionResult Index()
        {
            var model=dal.GetProducts();    

            return View(model);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var model = dal.GetProductById(id);
            return View(model);
            
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product prod)
        {
            int result = dal.AddProduct(prod);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
