using Assignment_13._2.Models;
using Assignment_13._2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_13._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IproductRepository productR;
        public ProductController()
        {
            productR = new ProductRepository();
        }
        [HttpGet]
        public ActionResult Index()
        {
            ViewProduct pp = new ViewProduct();
            pp.Products = productR.GetProducts();
            return Ok(pp.Products);
        }
        [HttpGet("{id}")]
        public ActionResult Select(int id)
        {
            var pro = productR.GetProduct(id);
            if(pro == null)
            {
                return NotFound();
            }
            return Ok(pro);
        }
    }
}
