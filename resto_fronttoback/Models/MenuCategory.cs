using System.ComponentModel.DataAnnotations;

namespace resto_fronttoback.Models
{
    public class MenuCategory
    {
        public int Id { get; set; }
        [StringLength(maximumLength:25,MinimumLength =3,ErrorMessage ="Minimum uzunluq 3 simvoldan,maximum ise 25 den ibaret olmalidir")]
        public string Title { get; set; }

    }
}
