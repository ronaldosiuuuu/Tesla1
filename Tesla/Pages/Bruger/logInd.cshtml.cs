using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Tesla.Models;

namespace Tesla.Bruger
{
    public class logIndModel : PageModel
    {
        [BindProperty]
        public logindOplysninger logindOplysninger { get; set; }

        [Required(ErrorMessage = "Enter a username"), Range(6, 30, ErrorMessage = "Your username must be between 6 and 30 characters"), Display(Name = "Email")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Enter a password"), StringLength(8, ErrorMessage = "The password must contain at least 8 characters"), Display(Name = "Password"), DataType(DataType.Password)]
        public string passWord { get; set; }
        public void OnGet()
        {
        }
    }
}
