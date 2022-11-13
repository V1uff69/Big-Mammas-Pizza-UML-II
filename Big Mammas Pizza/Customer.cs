namespace Big_Mammas_Pizza
{
    public class Customer
    {
        private static int NextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }



        public Customer(string name, string number, string email) 
        { 
            Id = NextId++;
            Name = name;
            Number = number;
            Email = email;

        }
        public override string ToString()
        {
            return
                $"Id: {Id}, " +
                $"Customer: {Name}, " +
                $"Phone: {Number}, " +
                $"Email: {Email}. ";
        }
    }
}
