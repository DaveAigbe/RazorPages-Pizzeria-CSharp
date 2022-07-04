namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        // Set up properties that will be connected to the ViewModel and used in the View
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 5;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Beef { get; set; }
        public bool Pineapple { get; set; }
        public bool Olives { get; set; }
        public bool Onions { get; set; }
        public float FinalPrice    { get; set; }
    }
}
