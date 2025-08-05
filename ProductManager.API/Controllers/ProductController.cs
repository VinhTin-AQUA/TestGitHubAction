using Microsoft.AspNetCore.Mvc;
using ProductManager.API.Models;
using ProductManager.API.Repositories;

namespace ProductManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository  productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(new { products = productRepository.GetAllProducts() });
        }
        
        [HttpPost]
        public IActionResult AddProduct(Product  product)
        {
            productRepository.Add(product);
            return Ok(new { product = product });
        }
    }
}