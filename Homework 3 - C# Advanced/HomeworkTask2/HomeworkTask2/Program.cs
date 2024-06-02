using HomeworkTask2.Models;

namespace HomeworkTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            MotorBike motorBike = new MotorBike();
            Boat boat = new Boat();
            Airplane plane = new Airplane();

            car.Drive();
            motorBike.Wheelie();
            boat.Sail();
            plane.Fly();
        }
    }
}
