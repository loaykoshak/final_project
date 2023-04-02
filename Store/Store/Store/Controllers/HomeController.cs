using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.Models.Data;
using System.Diagnostics;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            this._context = context;
        }

        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            var products = _context.products.ToList();

            Console.WriteLine(products.ToArray().ToString());
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //طالما ان هذي الدالة بتستقبل parameter فانا رحت عرفتلها في parameter تبعها متغير اسمه id
        public IActionResult Det(int id)
        {
            var productDetails = _context.productsDetails.Where(x => x.products.Id == id);
            //وروح ارسل بالمنتج مع view زي ما ارسلنابه هنا
            return View(productDetails);
        }

        public IActionResult Invoice(int id)
        {
            var productsDetails = _context.productsDetails.Where(x => x.products.Id == id);
            return View(productsDetails);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}