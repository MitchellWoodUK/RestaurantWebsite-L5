using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Data;
using RestaurantWebsite.Models;

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

        //GET operation for the create review
        public async Task<IActionResult> Create(int Id)
        {
            return View(Id);
        }


        [HttpPost]
        //POST operation for the create review
        public async Task<IActionResult> Create(ReviewModel review)
        {
            if (review == null)
            {
                return NotFound();
            }
            else
            {
                _context.Reviews.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }


    }
}
