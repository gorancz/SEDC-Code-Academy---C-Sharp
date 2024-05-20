using AbstractClassesAndInterfaces.Models;

namespace AbstractClassesAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Some text.");
            WebPage page = new WebPage("http://abstractclasses&interfaces.com", "<html>This is a sample webpage content.</html>");

            Console.WriteLine($"Searching 'sample' in Document: {doc.Search("sample")}");
            Console.WriteLine($"Searching 'webpage' in WebPage: {page.Search("webpage")}");

            Console.WriteLine("----------------------------------------");

            Rectangle rect = new Rectangle { Width = 5, Height = 10 };
            Circle circle = new Circle { Radius = 5 };
            Triangle triangle = new Triangle { Base = 5, Height = 10 };

            Console.WriteLine($"Area of Rectangle: {rect.GetArea()}");
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");
            Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");

            Console.WriteLine("----------------------------------------");

            Circle circ = new Circle { Radius = 5 };
            Triangle tri = new Triangle { Base = 5, Height = 10, SideA = 5, SideB = 5, SideC = 8 };

            Console.WriteLine($"Area of Circle: {circ.CalculateArea()}");
            Console.WriteLine($"Perimeter of Circle: {circ.CalculatePerimeter()}");
            Console.WriteLine($"Area of Triangle: {tri.CalculateArea()}");
            Console.WriteLine($"Perimeter of Triangle: {tri.CalculatePerimeter()}");

            Console.WriteLine("----------------------------------------");

            Manager manager = new Manager { Name = "Petar", BaseSalary = 40000, Bonus = 5000 };
            Programmer programmer = new Programmer { Name = "Milos", BaseSalary = 60000, CompletedProjects = 5 };

            manager.DisplayInfo();
            programmer.DisplayInfo();
        }
    }
}
