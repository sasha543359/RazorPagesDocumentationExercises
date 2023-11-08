using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace SecondProject.Pages
{
    [IgnoreAntiforgeryToken]
    public class Test2Model : PageModel
    {
        public string Message { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; } = default(int);

        public void OnPost(string name, int age)
        {
            Name = name;
            Age = age;
            Message = $"Name {Name} | Age {Age}";
        }

        public string PrintInfo()
        {
            return $"Final info {Message}";
        }
        
    }
}
