using Microsoft.AspNetCore.Mvc;
using SportsStore.Repositories.Abstractions;
using SportsStore.ViewModels;
using System.Linq;


namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _storeRepository;

        public HomeController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public IActionResult Index()
        {
            var productsQuery = from product in _storeRepository.Products
                                select new ProductVM
                                {
                                    Name = product.Name,
                                    Description = product.Description,
                                    Price = product.Price,
                                };

            return View(productsQuery);
        }
    }
}
