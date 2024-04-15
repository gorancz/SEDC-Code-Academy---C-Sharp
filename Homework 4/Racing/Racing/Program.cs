namespace Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Driver[] drivers = new Driver[]
            {
            new Driver() { 
                Name = "Bob", 
                Skill = 6 
            },
            new Driver() { 
                Name = "Greg", 
                Skill = 7 
            },
            new Driver() { 
                Name = "Jill", 
                Skill = 8 
            },
            new Driver() { 
                Name = "Anne", 
                Skill = 9 
            }
            };

            Car[] cars = new Car[]
            {
            new Car() { 
                Model = "Hyundai", 
                Speed = 160 
            },
            new Car() { 
                Model = "Mazda", 
                Speed = 180 
            },
            new Car() { 
                Model = "Ferrari", 
                Speed = 220 
            },
            new Car() { 
                Model = "Porsche", 
                Speed = 200 
            }
            };

            Console.WriteLine("Choose a car no.1:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            int carIndex1 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose Driver:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            int driverIndex1 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose a car no.2:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            int carIndex2 = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose Driver:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            int driverIndex2 = int.Parse(Console.ReadLine()) - 1;

            cars[carIndex1].Driver = drivers[driverIndex1];
            cars[carIndex2].Driver = drivers[driverIndex2];

            RaceCars(cars[carIndex1], cars[carIndex2]);
        }

        static void RaceCars(Car car1, Car car2)
        {
            int speed1 = car1.CalculateSpeed();
            int speed2 = car2.CalculateSpeed();

            if (speed1 > speed2)
            {
                Console.WriteLine($"Car no. 1 ({car1.Model}) was faster.");
            }
            else if (speed2 > speed1)
            {
                Console.WriteLine($"Car no. 2 ({car2.Model}) was faster.");
            }
            else
            {
                Console.WriteLine("Both cars have the same speed.");
            }
        }
    }
}
