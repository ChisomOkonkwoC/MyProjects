using Ecommerce.Contracts;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private static int _productId;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(int id)
        {
            if(id > 0)
            {
                _productId = id;
            }
            UserProductViewModel userProductViewModel = new UserProductViewModel();
            userProductViewModel.Product = await _productService.GetProductById(_productId);
            userProductViewModel.Products =  await _productService.GetAllProducts();
            return View(userProductViewModel);
        }
       
    }
}
