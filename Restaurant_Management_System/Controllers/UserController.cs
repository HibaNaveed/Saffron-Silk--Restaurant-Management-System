using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Controllers
{
    public class UserController : Controller
    {
        private readonly RestaurantDbContext _context;

        public UserController(RestaurantDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Bookatable(Bookatable model)
        {
            if (ModelState.IsValid)
            {
                _context.Table.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Confirmation");
            }
            return View("Index", model);
        }
        
        public IActionResult Confirmation()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult AddtoCart()
        {
            return View();
        }
    }
}
