using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Data;

namespace RestaurantWebsite.Controllers
{
    public class ProductController : Controller
    {
        //Inject the database into the controller so that we can use product data on the pages/views.
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET operation for the product index page
        public IActionResult Index()
        {
            return View();
        }


        //GET operation for the product create page
        public IActionResult Create()
        {
            return View();
        }
    }
}
