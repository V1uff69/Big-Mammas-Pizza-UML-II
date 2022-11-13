using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Big_Mammas_Pizza
{
    internal class Store
    {
        public static void StartMainMethod()
        {

            CreateCustomer();
            CreatePizza();

            #region Start Print-
            //start print full menu
            Console.WriteLine("Print Menu:");
            PizzaMenu.PrintMenu();
            Console.WriteLine();

            //start full customer list
            Console.WriteLine("Customers:");
            CustomerFile.PrintCustomerList();
            #endregion Start Print-

            #region Pizza Functions-
            //finds pizza by Id
            Console.WriteLine("Find Pizza By Id: 2");
            PizzaMenu.FindPizzaById(2);
            Console.WriteLine();
            
            //removes pizza By Id
            Console.WriteLine("remove Pizza By Id: 2");
            PizzaMenu.RemovePizzaById(2);
            Console.WriteLine();

            //Peparoni and pizza 2 should be removed + print menu.
            PizzaMenu.PrintMenu();
            Console.WriteLine();

            //find pizza by name
            Console.WriteLine("Find Pizza By name: Peparoni");
            PizzaMenu.FindPizzaByName("Peparoni");
            Console.WriteLine();

            //Remove pizza by name
            Console.WriteLine("Remove Pizza By name");
            PizzaMenu.RemovePizzaByName("Peparoni");
            Console.WriteLine();

            //print pizzamenu again
            // Peparoni and pizza [1] should be removed.
            PizzaMenu.PrintMenu();
            Console.WriteLine();

            //edit pizza
            Console.WriteLine("update pizza:");
            PizzaMenu.Update(3, "name", "Torbens Skinke ");
            PizzaMenu.PrintMenu();
            Console.WriteLine();
            #endregion Pizza Functions-

            #region Customer Fuctions-
            //find customer by name
            Console.WriteLine("find customer by name: Kenni");
            CustomerFile.FindCustomerByName("Kenni");
            Console.WriteLine();

            //edits Customer data by field with new input
            Console.WriteLine("update customer id 1, Kenni Viuff to Flemming");
            CustomerFile.Update(1, "name", "Flemming");
            Console.WriteLine();

            //remove customer by name : Joakim Von And
            Console.WriteLine("Remove Customer Joakim Von And");
            CustomerFile.RemoveCustomerByName("Joakim Von And");

            //prints updated list
            CustomerFile.PrintCustomerList();
            #endregion Customer Functions-

        }

        #region Add Pizza- 
        public static void CreatePizza()
        {
            ///Creates new  obects from constuctors
            ///Pizza
            PizzaMenu.AddPizza(30, "Peparoni", "Tomat, Ost, Peparoni");
            PizzaMenu.AddPizza(45, "Hawai", "Tomast, Ost, Skinke, Ananas");
            PizzaMenu.AddPizza(25, "Skinke", "Tomat, Ost, Skinke");
        }
        #endregion Add Pizza-

        #region Add Customer-
        public static void CreateCustomer()
        {
            ///Creates new  obects from constuctors
            ///Customer
            CustomerFile.AddCustomer("Kenni Viuff", "31 67 16 00", "KenniViuffbach@gmail.com");
            CustomerFile.AddCustomer("Joakim Von And", "99 99 99 99", "RigAnd@quack.duck");
            CustomerFile.AddCustomer("Mickey Mouse", "12 34 56 78", "MickeyMinnie@squeek.mouse");
            CustomerFile.AddCustomer("Kenni bach", "34 67 16 00", "Kennibach@gmail.com");
        }
        #endregion Add Customer-
    }
}
