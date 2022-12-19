using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla.Services;

namespace Tesla.Pages
{
    public class LogafModel : PageModel
    {
        private readonly IBrugerService _brugerService;
        public LogafModel(IBrugerService brugerService)
        {
            _brugerService = brugerService;
        }

        public IActionResult OnGet()
        {
            _brugerService.UserLoggedOut();
            return RedirectToPage("Index");
        }
    }
}
