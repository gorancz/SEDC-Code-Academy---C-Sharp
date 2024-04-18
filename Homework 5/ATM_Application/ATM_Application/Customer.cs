namespace ATM_Application
{
    public class Customer
    {
        public string CardNumber { get; set; }
        public int Pin { get; set; }
        public string FullName { get; set; }
        public double Balance { get; set; }

        public Customer(string cardNumber, int pin, string fullName, double balance)
        {
            CardNumber = cardNumber;
            Pin = pin;
            FullName = fullName;
            Balance = balance;
        }
    }
}
