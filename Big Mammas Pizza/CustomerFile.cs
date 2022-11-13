using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_Pizza
{
    public class CustomerFile
    {
        #region customers List-
        private static List<Customer> customers = new List<Customer>();
        public static void AddCustomer(string name, string number, string email) 
        {
            customers.Add(new Customer(name, number, email));
        }
        #endregion customers List-

        #region Find methods-
        public static bool FindCustomerByName(string customername)
        {
            foreach (Customer c in customers)
            {
                if (c.Name.ToUpper().Contains(customername.ToUpper())) 
                { 
                    Console.WriteLine(c);
                    return true;
                }
            }
            Console.WriteLine("not in list"); return false;
        }

        public static bool FindCustomerById(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)  Console.WriteLine(c);
                return true;
            }
            Console.WriteLine("not in list");  return false;  
        }
        #endregion

        #region Update Pizza-
        public static Customer Update(int Id, string field, string newValue) 
        { 
            foreach (Customer c in customers) 
            {
                if (c.Id == Id) 
                {
                    if (field.ToLower() == "name") 
                    {
                        c.Name = newValue;
                        return c;
                    }
                    if (field.ToLower() == "number")
                    {
                        c.Number = newValue;
                        return c;
                    }
                    if (field.ToLower() == "email")
                    {
                        c.Email = newValue;
                        return c;
                    }
                }
                Console.WriteLine($"ERROR: Field; {field} could not be found");
                return null;
            }
            Console.WriteLine($"ERROR: Id; {Id} could not be found!");
            return null;
        }
        #endregion

        #region Remove Customer-
        public static void RemoveCustomerByName(string customername)
        {
            List<Customer> tempList = new List<Customer>();
            
            foreach (Customer c in customers)
            {
                if (c.Name.ToUpper() != customername.ToUpper()) 
                { 
                    tempList.Add(c);
                }
                customers = tempList;
            }
            Console.WriteLine("not in list");
        }

        #endregion Remove Customer-

        #region Print Customer list-
        public static void PrintCustomerList() 
        {
            Console.WriteLine("Customer List: ");
            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }
        }
        #endregion

    }
}
