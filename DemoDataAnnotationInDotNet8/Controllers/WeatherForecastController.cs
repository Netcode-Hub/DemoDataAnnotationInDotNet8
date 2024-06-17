using Microsoft.AspNetCore.Mvc;

namespace DemoDataAnnotationInDotNet8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {


        [HttpPost]
        public IActionResult AddProduct(Product product) => Ok(product);
    }
}
