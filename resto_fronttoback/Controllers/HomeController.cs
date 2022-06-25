using Microsoft.AspNetCore.Mvc;
using resto_fronttoback.DAL;
using resto_fronttoback.ViewModels;
using System.Linq;

namespace resto_fronttoback.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Slider = _context.Sliders.ToList();
            homeVM.About = _context.About.FirstOrDefault();
            homeVM.AboutSpecialRecipes = _context.AboutSpecialRecipes.ToList();
            homeVM.Specialties = _context.Specialties.ToList();
            homeVM.Menu = _context.Menus.ToList();
            homeVM.MenuCategory = _context.MenuCategories.ToList();
            return View(homeVM);
        }
    }
}
