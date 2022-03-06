using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUIProject.Models;

namespace WebUIProject.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices productService;
        public ProductController(IProductServices productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var model = new ProductListView()
            {
                Products = productService.GetAll()

            };


            return View(model);
        }
    }
}
