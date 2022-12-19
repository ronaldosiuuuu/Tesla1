using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Tesla.Services;

namespace Tesla.Pages
{
    public class LogindModel : PageModel
    {
        private readonly IBrugerService _brugerService;

        public LogindModel(IBrugerService brugerService)
        {
            _brugerService = brugerService;
        }



        [BindProperty]
        [Display(Name="Username")]
        [Required]  
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Enter a username")]
        public String Name { get; set; }

        [BindProperty]
        [Required]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Enter a password"), Display(Name = "Password"), DataType(DataType.Password)]
        public String Password { get; set; }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            

            //if (Password != Password)
            //{
            //    return Page();
            //}

            if (!_brugerService.TjekLogInd (Name, Password))
            { 
                return Page();
            }

            return RedirectToPage("Index");

        }
    }
}