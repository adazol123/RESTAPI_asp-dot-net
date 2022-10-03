using ShopProduct.Models;
using ShopProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ShopProduct.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase {
    public ProductController() {

    }

    //get
    [HttpGet]
    public ActionResult<List<Product>> GetAll() => ProductService.GetAll();
}

