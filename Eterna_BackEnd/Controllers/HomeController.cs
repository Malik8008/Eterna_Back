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

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM 
            { 
                Sliders = await _context.Sliders.ToListAsync(),
                FirstCards = await _context.homeFirstCards.ToListAsync(),
                SecondCards = await _context.homeSecondCards.ToListAsync(), 
                Brands = await _context.brands.ToListAsync(),
            };

            return View(homeVM);
        }
    }
}
