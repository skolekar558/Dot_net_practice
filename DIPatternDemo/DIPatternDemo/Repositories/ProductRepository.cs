using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddProduct(Product product)
        {
            product.IsAvailable = product.StockQuantity > 0; // Assuming you meant to set this property
            db.Product.Add(product);
            return db.SaveChanges();
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var model = db.Product.Where(prod => prod.Id == id).FirstOrDefault();
            if (model != null)
            {
                model.IsAvailable = false;
                result = db.SaveChanges();
            }
            return result;
            
        }

        public int EditProduct(Product product)
        {
            int result = 0;
            var model = db.Product.Where(prod => prod.Id ==product.Id).FirstOrDefault();
           
            if (model != null)
            {
                model.Name = product.Name;
                model.Description = product.Description;
                model.Price = product.Price;
                model.StockQuantity = product.StockQuantity;
                
                model.IsAvailable = true;
               
                result = db.SaveChanges();
            }
            return result;
        }

        public Product GetProductById(int id)
        {
            return db.Product.Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            var model = (from prod in db.Product
                         where prod.IsAvailable == true
                         select prod).ToList();
            return model;
        }
    }
}
