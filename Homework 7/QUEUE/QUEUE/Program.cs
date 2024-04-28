namespace QUEUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            while (true)
            {
                Console.Write("Enter a number: ");
                string number = Console.ReadLine();

                if (int.TryParse(number, out int parsedNumber))
                {
                    queue.Enqueue(parsedNumber);
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a valid number.");
                    continue;
                }

                while (true)
                {
                    Console.Write("Do you want to input another number? (Y/N): ");
                    string continueInput = Console.ReadLine().ToLower();

                    if (continueInput == "y")
                    {
                        break;
                    }
                    else if (continueInput == "n")
                    {
                        Console.WriteLine("The numbers in the order that you entered them are:");
                        while (queue.Count > 0)
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter 'Y' for yes or 'N' for no.");
                    }
                }
            }
        }
    }
}
