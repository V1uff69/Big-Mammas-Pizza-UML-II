using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_Pizza
{
    public class PizzaMenu

    {
        #region Dictionary construction
        private static Dictionary<int,Pizza> pizzas = new Dictionary<int,Pizza>();

        public static void AddPizza(double pizzaPrice, string pizzaName, string pizzaTopping)
        {
            Pizza pizza = new Pizza(pizzaPrice, pizzaName, pizzaTopping);
            pizzas[pizza.Id] = pizza;
        }
        #endregion

        #region Find Pizza
        public static bool FindPizzaById(int Id)
        {
            foreach (Pizza p in pizzas.Values)
            {
                if (p.Id == Id) Console.WriteLine(p); return true;
            }
            Console.WriteLine("not in list"); return false;
        }

        public static bool FindPizzaByName(string name)
        {
            foreach (Pizza p in pizzas.Values)
            {
                if (p.PizzaName.ToLower().Contains(name.ToLower())) Console.WriteLine(p); return true;
            }
            Console.WriteLine("not in list"); return false;
        }

        public bool FindPizzaByTopping(string topping)
        {
            foreach (Pizza p in pizzas.Values)
            {
                if (p.PizzaTopping.ToLower().Contains(topping.ToLower())) Console.WriteLine(p); return true;
            }
            Console.WriteLine("not found"); return false;
        }
        #endregion

        #region Update Pizza in list
        public static Pizza Update(int Id, string field, string newValue)
        {
            foreach (var p in pizzas)
            {
                if (p.Key == Id)
                {
                    if (field.ToLower() == "name")
                    {
                        p.Value.PizzaName = newValue;
                        return p.Value;
                    }
                    if (field.ToLower() == "number")
                    {
                        p.Value.Id = Convert.ToInt32(newValue);
                        return p.Value;
                    }
                    if (field.ToLower() == "topping")
                    {
                        p.Value.PizzaTopping = newValue;
                        return p.Value;
                    }
                    if (field.ToLower() == "price")
                    {
                        p.Value.PizzaPrice = Convert.ToInt32(newValue);
                        return p.Value;
                    }
                }
                Console.WriteLine($"ERROR: Field; {field} could not be found");
                return null;
            }
            Console.WriteLine($"ERROR: Id; {Id} could not be found!");
            return null;
        }
        #endregion

        #region Remove pizza from list
        public static bool RemovePizzaById(int Id) 
        {
            foreach (Pizza p in pizzas.Values)
            {
                if (p.Id == Id) { Console.WriteLine($"{p.PizzaName} Pizza have been removed from menu"); pizzas.Remove(p.Id);return true; }
            }
            Console.WriteLine("not found"); return false;
        }

        public static bool RemovePizzaByName(string name)
        {
            foreach (Pizza p in pizzas.Values)
            {
                if (p.PizzaName.ToLower() == name.ToLower()) { Console.WriteLine($"{p.PizzaName} Pizza have been removed from menu"); pizzas.Remove(p.Id); return true; }
            }
            Console.WriteLine("not found"); return false;
        }
        #endregion

        #region Print menu
        public static void PrintMenu()
        {
            Console.WriteLine("Menu Kort");
            foreach (Pizza p in pizzas.Values)
            {
                Console.WriteLine(p);
            }
        }
        #endregion
    }
}
