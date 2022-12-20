using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla.BilModels;

namespace Tesla.Pages.bil
{
    public class ModelSModel : PageModel
    {

        Bil elon = new Bil("Model s", 1500000, "den bedste bil ");
        
        public void OnGet()
        {
        }
    }
}
