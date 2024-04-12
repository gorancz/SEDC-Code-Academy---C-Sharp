namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your birthdate (format: yyyy-mm-dd): ");

            string input = Console.ReadLine();

            DateTime birthDate;
            if (DateTime.TryParse(input, out birthDate))
            {
                int age = CalculateAge(birthDate);

                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("The date you entered is not valid. Please try again.");
            }
        }
        static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
