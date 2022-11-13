
namespace Big_Mammas_Pizza
{
    public class Order
    {
        #region Property
        public int OrderNo { get; set; } //property - also creating hidden instance
        public Customer Name { get; set; } //property - also creating hidden instance
        public Pizza Pizza { get; set; } //property - also creating hidden instance
        public double OrderTotalprice { get; set; } //property - also creating hidden instance
        #endregion Property

        #region instance
        public double Tax = 1.25; //Data type double "0.0" - Tax is 25% = x / 100 * 25 + x = x * 1.25 = New x
        public int Delivery = 40; //Data type integer "0" - Deleivery is 40 kr.
        #endregion instance

        #region Constructor
        public Order(int orderNo, Customer name, Pizza pizza) //Constucting template of an order calling information from class Customer and Pizza
        {
            OrderNo = orderNo; //sets orderNo for individual object created
            Name = name; //sets name and call from Class Customer for individual object created
            Pizza = pizza; //setss pizza and call from Class Pizza for individual object created
            OrderTotalprice = 0; //total price updates when pizza is added and calculated on instatiation for individual object created
        }
        #endregion Constructor

        #region ToString Property
        public override string ToString() //coverts construcctor-propertyList to string(text) and overrides output to string.
        {
            CalculateTotalPrice(); //instatiation method to set total price after calcultation
            return $"-------------------------------------------------------------" +
                $"\nOrder Nr: {OrderNo}" +
                $"\n{Name}" +
                $"\nPizza: {Pizza}" +
                $"\nPrice: {OrderTotalprice}" +
                $"\n-------------------------------------------------------------";
        }
        #endregion ToString Property

        #region Method
        public void CalculateTotalPrice() //method to calculate total price of a individual order.
        {
            OrderTotalprice = (Pizza.PizzaPrice * Tax) + Delivery; //math
        }
        #endregion Method
    }

}
