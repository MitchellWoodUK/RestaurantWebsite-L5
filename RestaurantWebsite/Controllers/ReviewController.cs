using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Data;

namespace RestaurantWebsite.Controllers
{
    public class ReviewController : Controller
    {
        //Inject the database
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Get operation for the review index.
        public async Task<IActionResult> Index()
        {
            var reviews = await _context.Reviews.Include(r => r.Product).ToListAsync();
            //r represents each individual item
            //.product attaches the corresponding product to each individual review
            
            return View(reviews);
        }
    }
}
