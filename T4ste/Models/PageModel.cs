using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace T4ste.Models
{
    public class IndexModel : PageModel
    {
        public string Name { get; private set;} = "PageModel in C#";
        public void OnGet()
        {
            Name += $" Server time is { DateTime.Now }";
        }   

        public void OnPostSubmit(PersonModel person)
        {
            this.Name = string.Format("Name: {0} {1}", person.FirstName, person.LastName);
        }
    }
}
