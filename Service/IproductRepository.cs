using Assignment_13._2.Models;

namespace Assignment_13._2.Service
{
    public interface IproductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int? id);
    }
}
