using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace SecondProject.Pages
{
    [IgnoreAntiforgeryToken]
    public class PageHandlersModel : PageModel
    {
        

        List<Person> persons = new List<Person>()
        {
            new Person ("Tom", "Smith", 23),
            new Person ("Sam", "Anderson", 23),
            new Person ("Bob", "Johnson", 25),
            new Person ("Tom", "Anderson", 25)
        };

        public List<Person> result { get; private set; } = new List<Person>();

        public void OnGet()
        {
            result = persons;
        }

        public void OnGetByName(string name)
        {
            result = persons.Where(p => p.FirstName == name).ToList();
        }

        public void OnGetByAge(int age)
        {
            result = persons.Where(p => p.Age == age).ToList();
        }


    }
}
