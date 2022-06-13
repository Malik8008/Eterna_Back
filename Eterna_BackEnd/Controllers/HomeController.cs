using Eterna_BackEnd.DAL;
using Eterna_BackEnd.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Eterna_BackEnd.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Home()
        {
            HomeVM homeVM = new HomeVM 
            { 
                Sliders = await _context.Sliders.ToListAsync(),
            };

            return View(homeVM);
        }
    }
}
