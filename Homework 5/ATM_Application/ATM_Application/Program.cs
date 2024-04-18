namespace ATM_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[]
            {
                new Customer ("123456789", 1234, "Mika Mikic", 2500),
                new Customer ("987654321", 5678, "Pera Peric", 8500)
            };

            Customer customer = null;
            while (customer == null)
            {
                Console.WriteLine("Welcome to ATM!");
                Console.WriteLine("Please enter your card number:");
                string cardNumber = Console.ReadLine();

                Console.WriteLine("Enter your pin:");
                int pin = Convert.ToInt32(Console.ReadLine());

                foreach (Customer c in customers)
                {
                    if (c.CardNumber == cardNumber && c.Pin == pin)
                    {
                        customer = c;
                        break;
                    }
                }

                if (customer == null)
                {
                    Console.WriteLine("Invalid card number or pin. Please try again.");
                }
            }

            Console.WriteLine($"Welcome {customer.FullName}!");

            while (true)
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Cash Withdrawal");
                Console.WriteLine("3. Cash Deposit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: {customer.Balance}$");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw <= customer.Balance)
                        {
                            customer.Balance -= withdraw;
                            Console.WriteLine($"You withdrew {withdraw}$. You have {customer.Balance}$ left on your account.");
                            Console.WriteLine("Thank you for using the ATM app.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to deposit:");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        customer.Balance += deposit;
                        Console.WriteLine($"You deposited {deposit}$. You have {customer.Balance}$ on your account.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
