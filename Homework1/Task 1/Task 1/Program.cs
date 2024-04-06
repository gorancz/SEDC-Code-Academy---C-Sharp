namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /).");
                    return;
            }

            Console.WriteLine($"The result is: {result}");
        }
    }
}
