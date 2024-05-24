using Meetup.DAL;
using Meetup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Meetup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Employees.Select(t => new Employee
            { 
                Id = t.Id,
                Name = t.Name,
                Image = t.Image,
                Title=t.Title

            }).ToListAsync();
            return View(data);
        }
    }
}
