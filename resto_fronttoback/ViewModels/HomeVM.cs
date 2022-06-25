using resto_fronttoback.Models;
using System.Collections.Generic;

namespace resto_fronttoback.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slider { get; set; }
        public About About { get; set; }
        public IEnumerable<AboutSpecialRecipe> AboutSpecialRecipes { get; set; }
        public IEnumerable<Specialties> Specialties { get; set; }
        public IEnumerable<Menu> Menu { get; set; }
        public IEnumerable<MenuCategory> MenuCategory { get; set; }
    }
}
