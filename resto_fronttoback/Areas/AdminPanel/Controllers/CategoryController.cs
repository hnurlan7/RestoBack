using Microsoft.AspNetCore.Mvc;
using resto_fronttoback.DAL;
using resto_fronttoback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resto_fronttoback.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<MenuCategory> menuCategories = _context.MenuCategories.ToList();
            return View(menuCategories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MenuCategory category)
        {
            _context.MenuCategories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            MenuCategory old = _context.MenuCategories.FirstOrDefault(x => x.Id == id);
            if(old==null)
            {
                return NotFound();
            }
            return View(old);
        }
        [HttpPost]
        public IActionResult Update(MenuCategory category)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Melumatlar duzgun deyil");
                return View(category);
            }
            MenuCategory oldCategory = _context.MenuCategories.FirstOrDefault(x => x.Id == category.Id);
            oldCategory.Title = category.Title;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            MenuCategory deletedCategory = _context.MenuCategories.FirstOrDefault(x => x.Id == id);
            if(deletedCategory==null)
            {
                return NotFound();
            }
            _context.MenuCategories.Remove(deletedCategory);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        
    }
}
