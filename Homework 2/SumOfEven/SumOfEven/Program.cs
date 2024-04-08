namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter integer no.{i + 1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine($"The result is: {sum}");
        }
    }
}
