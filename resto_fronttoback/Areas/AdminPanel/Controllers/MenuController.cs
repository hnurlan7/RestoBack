using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using resto_fronttoback.DAL;
using resto_fronttoback.Helpers;
using resto_fronttoback.Models;
using System;
using System.IO;
using System.Linq;

namespace resto_fronttoback.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MenuController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public MenuController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        
        public IActionResult Index()
        {
           var menus = _context.Menus.Include(x => x.MenuCategory).ToList();
            return View(menus);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryIds = _context.MenuCategories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu menu)

        {
            ViewBag.CategoryIds = _context.MenuCategories.ToList();

            if (!ModelState.IsValid)
            {
                return View(menu);
            }
          if(menu.FormFile!=null)
            {
                if(FileManager.CheckFormFile(menu.FormFile))
                {
                  menu.ImageUrl=  FileManager.Save(_env.WebRootPath, "uploads/menu", menu.FormFile);
                }
           }
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.CategoryIds = _context.MenuCategories.ToList();

            Menu oldMenu = _context.Menus.FirstOrDefault(x => x.Id == id);
            if(oldMenu==null)
            {
                return NotFound();
            }
            return View(oldMenu);
        }
        [HttpPost]
        public IActionResult Update(Menu menu)
        {
            Menu oldMenu = _context.Menus.FirstOrDefault(x => x.Id == menu.Id);
            if (oldMenu == null)
            {
                return NotFound();
            }
            oldMenu.Title = menu.Title;
            oldMenu.Subtitle = menu.Subtitle;
            oldMenu.Price = menu.Price;
            if (menu.FormFile != null)
            {
                FileManager.Delete(_env.WebRootPath, "uploads/menu", oldMenu.ImageUrl);
                if (FileManager.CheckFormFile(menu.FormFile))
                {
                    oldMenu.ImageUrl = FileManager.Save(_env.WebRootPath, "uploads/menu", menu.FormFile);
                }
            }
            
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Menu menu = _context.Menus.FirstOrDefault(x => x.Id == id);
            if (menu == null)
            {
                return NotFound();
            }
            if(menu.ImageUrl!=null)
            {
                FileManager.Delete(_env.WebRootPath, "uploads/menu", menu.ImageUrl);
            }
            _context.Menus.Remove(menu);
/*            _context.SaveChanges();
*/            
            return RedirectToAction("index");
        }
    }
}
