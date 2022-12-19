using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Xml.Linq;
using Tesla.Models;
using Tesla.Services;

namespace Tesla.Pages
{
    public class CreateLogindModel : PageModel
    {
        private IBrugerService _brugerService;
        //[BindProperty]
        //[Required]
        //public string Createusername { get; set; }
        //[BindProperty]
        //[Required]
        //public string Createpassword { get; set; }
        [BindProperty]
        public LoggetInd LoggetInd { get; set; }

        public CreateLogindModel(IBrugerService service)
        {
            _brugerService = service;

        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            LoggetInd.IsAdmin = false;
            _brugerService.TilføjBruger(LoggetInd);
            return RedirectToPage("Logind");

            
            
        }
    }
   
}
