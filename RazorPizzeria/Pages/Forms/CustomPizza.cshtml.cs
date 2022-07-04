using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// Must use namespace to use Model
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        // Binds the PizzaModel to the CustomPizzaModel
        // This is essentially binding Model to ViewModel
        // Allows us to access/create pizzas from the CustomPizza view
        // Only binds PizzaModel Pizza
        [BindProperty]

        // Creates a PizzaModel item from Models
        // Item will be known as Pizza.(whatever) to access an item located in the Model
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {

        }

        // can return a response or error
        public IActionResult OnPost()
        {
            // Set the current price to the base price of the pizza
            PizzaPrice = Pizza.BasePrice;

            // Use if statements to increase the price of pizza based on toppings
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 3;
            if (Pizza.Pineapple) PizzaPrice += 2;
            if (Pizza.Olives) PizzaPrice += 2;
            if (Pizza.Onions) PizzaPrice += 2;

            // Redirect page to checkout and send over a new object that contains the name and price of the pizza
            return RedirectToPage("/Checkout/CheckOut", new {Pizza.PizzaName, PizzaPrice});
            


        }
    }
}
