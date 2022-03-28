using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie4.Models;
namespace Zadanie4.Pages.Shared
{

    public class ResultsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public User user { get; set; }

        [BindProperty(SupportsGet = true)]
        public string bmiMessage { get; set; }
        public void OnGet()
        {
           
        }
    }
}
