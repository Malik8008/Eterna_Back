using Eterna_BackEnd.DAL;
using Eterna_BackEnd.Models;
using Eterna_BackEnd.ViewModels.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eterna_BackEnd.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ServiceVM service = new ServiceVM
            {
                Settings = await _context.Settings.ToListAsync(),
                Cards = await _context.Cards.ToListAsync(),
                Skills = await _context.Skills.ToListAsync(),
                Progresss = await _context.Progresses.ToListAsync(),
            };

            return View(service);
        }
    }
}
