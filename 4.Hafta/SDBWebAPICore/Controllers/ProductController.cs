using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SDBWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Ürünleri depolamak için private static liste oluşturuldu.
        private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 5000, Category = "Electronics" },
        new Product { Id = 2, Name = "Smartphone", Price = 3000, Category = "Electronics" },
        new Product { Id = 3, Name = "T-Shirt", Price = 50, Category = "Clothing" }
    };

        // Ürün listesini JSON formatında döndüren endpoint
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }

        // Belirli bir ürünü JSON formatında döndüren endpoint
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // Yeni bir ürünü kaydeden endpoint
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _products.Add(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        // Bir ürünü güncelleyen endpoint
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Category = product.Category;
            return NoContent();
        }

        // Belirli bir ürünü silen endpoint
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _products.Remove(product);
            return NoContent();
        }
    }
}
