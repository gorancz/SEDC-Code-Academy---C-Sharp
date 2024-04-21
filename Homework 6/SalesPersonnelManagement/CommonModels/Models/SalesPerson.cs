using CommonModels.Enums;
namespace CommonModels.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue;

        public SalesPerson(string firstName, string lastName, double initialSalary, Role role)
            : base(firstName, lastName, initialSalary, Role.Sales)
        {

        }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            double bonus;
            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else
            {
                bonus = 1500;
            }

            return base.GetSalary() + bonus;
        }
    }
}
