using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPnet_HW_1.Pages
{
    public class CountriesModel : PageModel
    {
        public List<string> Countries { get; set; } = new List<string>() {"Singapore", "Taiwan", "Ukraine", "Germany", "Prague" };
        
        public void OnGet()
        {
        }
    }
}
