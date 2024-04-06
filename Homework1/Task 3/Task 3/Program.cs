namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number: {firstNumber}");
            Console.WriteLine($"Second Number: {secondNumber}");
        }
    }
}
