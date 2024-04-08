namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Goran", "Milica", "Stefan", "Tamara", "Sava" };

            Console.WriteLine("Enter student group: ( 1 or 2 )");
            int groupNumber = Convert.ToInt32(Console.ReadLine());

            switch (groupNumber)
            {
                case 1:
                    Console.WriteLine("The Students in group 1 are:");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 2:
                    Console.WriteLine("The Students in group 2 are:");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid group number.");
                    break;
            }
        }
    }
}
