using CommonModels.Enums;
using CommonModels.Models;

namespace SalesPersonnelManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Goran", "Radenkovic", 2000, Role.Other);
            employee.PrintInfo();
            Console.WriteLine($"Salary: {employee.GetSalary()}$");

            Console.WriteLine("---------------------------------------------");

            Manager manager = new Manager("Almir", "Vuk", 4000, Role.Manager);
            manager.AddBonus(500);
            manager.PrintInfo();
            Console.WriteLine($"Salary + Bonus: {manager.GetSalary()}$");

            Console.WriteLine("---------------------------------------------");

            double initialSuccessSaleRevenue = 2000;
            SalesPerson salesPerson = new SalesPerson("Milica", "Dujakovic", 500, Role.Sales, initialSuccessSaleRevenue);
            salesPerson.AddSuccessRevenue(6000);
            salesPerson.PrintInfo();
            Console.WriteLine($"Salary + Bonus: {salesPerson.GetSalary()}$");
        }
    }
}
