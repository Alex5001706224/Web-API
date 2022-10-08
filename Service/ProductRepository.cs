using Assignment_13._2.Models;

namespace Assignment_13._2.Service
{
    public class ProductRepository : IproductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 51, PName = "Benz", PDescription = "Benz New Car", ImageName = "Benz.jfif", Price = 153825 });
            products.Add(new Product() { Id = 52, PName = "Bugatti", PDescription = "Bugatti New Model", ImageName = "bugatti.jfif", Price = 372658 });
            products.Add(new Product() { Id = 53, PName = "Lamborghini", PDescription = "Lamborghini, do you want it?", ImageName = "lamborghini.jfif", Price = 435699 });
            products.Add(new Product() { Id = 54, PName = "Mclaren", PDescription = "What about McLaren?", ImageName = "mclaren.jfif", Price = 368999 });
        }
     

        public Product GetProduct(int? id)
        {
            if(products == null)
            {
                return null;
            }
            else
            {
                return products.Find(x => x.Id == id);
            }
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
