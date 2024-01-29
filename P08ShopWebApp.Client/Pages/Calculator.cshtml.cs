using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P08ShopWebApp.Client.Pages
{
    public class CalculatorModel : PageModel
    {
        public void OnGet()
        {
           
		}

        public void OnPost()
        {
			var form = Request.Form;

			bool r1 = int.TryParse(form["Number1"], out int number1);
			bool r2 = int.TryParse(form["Number2"], out int number2);
		}
    }
}
