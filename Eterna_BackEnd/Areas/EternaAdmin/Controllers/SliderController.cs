using Eterna_BackEnd.DAL;
using Eterna_BackEnd.FileUtilities;
using Eterna_BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eterna_BackEnd.Areas.EternaAdmin.Controllers
{
    [Area("EternaAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Slider sliders = await _context.Sliders.FirstOrDefaultAsync(p=>p.Id==id);
            if (sliders == null) return NotFound();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider,int id)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Photo != null)
            {
                if (!slider.Photo.ContentType.Contains("image"))
                {
                    return View();
                }
                if (slider.Photo.Length > 1024 * 1024)
                {
                    return View();
                }
            }
            slider.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets/IMG/slider-image");
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            Slider sliders = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
            if (sliders == null) return NotFound();
            return View(sliders);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(Slider slider,int id)
        {
            Slider existedSlider = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
            if (existedSlider == null) return NotFound();
            if (slider.Id != id) return BadRequest();
            existedSlider.Title = slider.Title;
            existedSlider.Subtitle=slider.Subtitle;
            existedSlider.OrangeTitle = slider.OrangeTitle;
            existedSlider.Image = slider.Image;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
            if (slider == null) return NotFound();
            if (slider.Id!=id) return BadRequest();
            return View(slider);    
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteSlider(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(p => p.Id == id);
            if(slider == null) return NotFound();
            _context.Sliders.Remove(slider);
             await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
