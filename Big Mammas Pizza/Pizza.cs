namespace Big_Mammas_Pizza
{
    public class Pizza
    {
        private static int NextId = 1;
        public int Id { get; set; }
        public double PizzaPrice { get; set; }
        public string PizzaName { get; set; }
        public string PizzaTopping {get; set;}

        public Pizza(double pizzaPrice, string pizzaName, string pizzaTopping)
        {
            Id = NextId++;
            PizzaPrice = pizzaPrice;
            PizzaName = pizzaName;
            PizzaTopping = pizzaTopping;
        }
        public override string ToString()
        {
            return $"{Id}: Price {PizzaPrice} - {PizzaName} - {PizzaTopping}";
        }

    }

}
