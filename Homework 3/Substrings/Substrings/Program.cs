namespace Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Substrings();
        }

        static void Substrings()
        {
            string str = "Hello from SEDC Codecademy 2024";
            Console.WriteLine("Enter a number:");

            int n;
            bool isNumber = Int32.TryParse(Console.ReadLine(), out n);

            if (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            if (n > str.Length)
            {
                Console.WriteLine($"The number you entered is greater than the length of the string. The length of the string is {str.Length}.");
                return;
            }

            string substring = str.Substring(0, n);
            Console.WriteLine($"The first {n} characters from the string are: {substring}");
            Console.WriteLine($"The length of the new string is: {substring.Length}");
        }
    }
}

