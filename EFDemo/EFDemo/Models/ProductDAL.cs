using EFDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace EFDemo.Models
{
    public class ProductDAL
    {
        private ApplicationDBContext db;
        public ProductDAL(ApplicationDBContext db)
        {
            this.db = db;
            
        }
        public List<Product> GetProducts() { 
        return db.Product.ToList();
        }
        public Product GetProductById(int id) {
            var model = db.Product.Where(x => x.PID == id).SingleOrDefault();
            return model;
        }
        public int AddProduct(Product prod)
        {
            int result = 0;
            db.Product.Add(prod);
            result=db.SaveChanges();
            return result;
        }

        public int EditProduct(Product prod) {
            int result = 0;
            var model = db.Product.Where(x => x.PID == prod.PID).SingleOrDefault();
            if (model != null)
            {
                
                model.PName = prod.PName; // model will hold old data
                model.Price = prod.Price;
               
                result = db.SaveChanges();

            }
            return result;

        }
        public int  DeleteProduct(int id)
        {
            int result = 0;
            var model = db.Product.Where(x => x.PID == id).SingleOrDefault();
            if (model != null)
            {

                db.Product.Remove(model);
                result = db.SaveChanges();

            }
            return result;
        }
    }
}
