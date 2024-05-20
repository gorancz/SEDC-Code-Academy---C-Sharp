namespace AbstractClassesAndInterfaces.Models
{
    public class Programmer : Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public int CompletedProjects { get; set; }

        public override decimal CalculateSalary()
        {
            return BaseSalary + (CompletedProjects * 500);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer Name: {Name}, Salary: {CalculateSalary()}");
        }
    }
}
