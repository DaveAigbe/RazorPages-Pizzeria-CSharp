using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages.Checkout
{
    // Binds all properties so they can be used in the view
    // This is outside of the class because there are 3 properties that need to be binded
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        // 3 properties that will be used in the view
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            // Check to see if fields are blank, if they are give them default values
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
