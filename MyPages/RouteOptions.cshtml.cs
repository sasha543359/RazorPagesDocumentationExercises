using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace SecondProject.Pages
{
    [IgnoreAntiforgeryToken]
    public class RouteOptionsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; } = "default";
        [BindProperty(SupportsGet = true)]
        public int? Age { get; set; }
        [BindProperty(SupportsGet = true, Name = "desc")]
        public string? Description { get; set; }


    }
}
