

namespace Racing
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }
    }
}
