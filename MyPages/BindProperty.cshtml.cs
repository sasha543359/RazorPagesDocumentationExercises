using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace SecondProject.Pages
{
    [IgnoreAntiforgeryToken]
    public class BindPropertyModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public Person? person { get; set; }

        [BindProperty(SupportsGet = true, Name = "tname")]
        public int testnumber { get; set; }

    }
}
