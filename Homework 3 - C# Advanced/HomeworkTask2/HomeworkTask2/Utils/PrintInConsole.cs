namespace HomeworkTask2.Utils
{
    public class PrintInConsole
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }

        public void PrintCollection<T>(List<T> collection)
        {
            foreach (T item in collection)
            {
                Print(item);
            }
        }
    }
}
