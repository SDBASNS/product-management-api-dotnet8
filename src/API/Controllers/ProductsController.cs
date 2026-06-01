using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products =
    [
        new Product
        {
            Id = 1,
            ProductName = "Laptop"
        },

        new Product
        {
            Id = 2,
            ProductName = "Mouse"
        }
    ];

    // GET: api/v1/products
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(Products);
    }

    // GET: api/v1/products/1
    [HttpGet("{id}")]
    public IActionResult GetProductById(int id)
    {
        var product = Products.FirstOrDefault(x => x.Id == id);

        if (product == null)
        {
            return NotFound(new
            {
                Message = "Product not found"
            });
        }

        return Ok(product);
    }

    // POST: api/v1/products
    [Authorize]
    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        product.Id = Products.Max(x => x.Id) + 1;

        Products.Add(product);

        return CreatedAtAction(
            nameof(GetProductById),
            new { id = product.Id },
            product);
    }

    // PUT: api/v1/products/1
    [Authorize]
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product updatedProduct)
    {
        var product = Products.FirstOrDefault(x => x.Id == id);

        if (product == null)
        {
            return NotFound(new
            {
                Message = "Product not found"
            });
        }

        product.ProductName = updatedProduct.ProductName;

        return NoContent();
    }

    // DELETE: api/v1/products/1
    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = Products.FirstOrDefault(x => x.Id == id);

        if (product == null)
        {
            return NotFound(new
            {
                Message = "Product not found"
            });
        }

        Products.Remove(product);

        return NoContent();
    }
}

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = string.Empty;
}