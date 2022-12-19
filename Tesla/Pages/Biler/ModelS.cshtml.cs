using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla.BilModels;

namespace Tesla.Pages.bil
{
    public class ModelSModel : PageModel
    {

        Bil bil = new Bil("Model s", 1500000, "den bedste bil ");
        
        //public double GetTotalPrice()
        //{
        //    double totalPrice = 0;
        //    foreach (Product product in products)
        //    {
        //        totalPrice += product.Price;
        //    }
        //    return totalPrice;
        //}
        public void OnGet()
        {
        }
    }
}
