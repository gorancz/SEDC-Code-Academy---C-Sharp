using CommonModels.Enums;
namespace CommonModels.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Role Role { get; set; }

        public Employee(string firstName, string lastName, double initialSalary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = initialSalary;
            Role = role;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Salary: {Salary}$");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }

    
}
