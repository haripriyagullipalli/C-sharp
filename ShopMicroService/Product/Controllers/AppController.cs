using Microsoft.AspNetCore.Mvc;
using Product.Models;
[Controller]
[Route("api/[controller]")]
public class AppController : Controller
{
    private readonly Products _products;

    public AppController(Products products)
    {
        _products = products;
    }

    [HttpGet("products")]
    public IActionResult GetProducts()
    {
        return Ok(_products.GetProducts);
    }

    [HttpPost("product")]
    public IActionResult CreateProduct([FromBody] ProductInfo productInfo)
    {
        bool isProductExists = _products.GetProducts.Any(x => x.Name == productInfo.Name);
        if (isProductExists)
        {
            return BadRequest("Product already exists");
        }
        _products.AddProduct(productInfo);
        return Ok("Product created");
    }
}

