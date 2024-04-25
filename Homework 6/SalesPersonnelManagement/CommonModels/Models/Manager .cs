using CommonModels.Enums;
namespace CommonModels.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, Role role)
            : base(firstName, lastName, Role.Manager)
        {

        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
    }
}
