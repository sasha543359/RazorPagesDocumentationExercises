using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecondProject.MyPages
{
    public class ReturningResultModel : PageModel
    {
        public IActionResult OnGet(string? name)
        {
            if(name != null) return Content($"Hello {name}");
            return Page();
        }
    }
}
