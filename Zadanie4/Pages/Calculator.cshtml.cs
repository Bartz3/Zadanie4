using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie4.Models;

namespace Zadanie4.Pages.Shared
{
    public class CalculatorModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public User user { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(User user)
        {
            
            if (ModelState.IsValid)
            {
                if (user.HeightUnit == "m") user.Result = Math.Round((user.Weight / ((user.Height) * (user.Height))), 2);
                else user.Result = Math.Round((user.Weight / ((user.Height / 100) * (user.Height / 100))), 2);

                return RedirectToPage("Results", user);
            }
            else
            {
                return Page();
            }
        }
    }
}
