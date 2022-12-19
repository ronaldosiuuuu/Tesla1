using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla.Services;

namespace Tesla.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBrugerService _brugerService;


        public bool IsAdmin
        {
            get
            {
                return _brugerService.IsUserAdmin;
            }
        }

        public String Name
        {
            get
            {
                return _brugerService.Username;
            }
        }

        public IndexModel(IBrugerService brugerService)
        {
           _brugerService = brugerService;
        }

        public IActionResult OnGet()
        {
        
            if (!_brugerService.IsLoggedIn)
            {
                return RedirectToPage("Logind");
            }

            return Page();
        }
    }
}