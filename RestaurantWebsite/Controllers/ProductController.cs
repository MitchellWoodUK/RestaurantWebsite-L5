using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Data;
using RestaurantWebsite.Models;

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
        public async Task<IActionResult> Index()
        {
            //Retrieving all of the products from the database table
            //Returning them to a list on the page
            return View(await _context.Products.ToListAsync());
        }


        //GET operation for the product create page
        public IActionResult Create()
        {
            return View();
        }

        //POST operation to send the create data to the database
        [HttpPost]
        public async Task<IActionResult> Create(ProductModel product)
        {
            //Add the new product to the products table
            _context.Products.Add(product);

            //Save the database changes
            await _context.SaveChangesAsync();

            //Redirect to the product index page
            return RedirectToAction(nameof(Index));
        }

    }
}
