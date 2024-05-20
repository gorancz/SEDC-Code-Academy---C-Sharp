namespace AbstractClassesAndInterfaces.Models
{
    public class Manager : Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }

        public override decimal CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Name: {Name}, Salary: {CalculateSalary()}");
        }
    }
}
