using ExeptionsExamples.Exeptions;
using System;

namespace ExeptionsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any number: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Koren broja je : {SquareRoot}");

                double result = 10 / number;

                //List<int> list = null;

                //list.Add(number);

                int[] numbersArray = new int[5];
                numbersArray[10] = 10;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("It seems like there is an error with data, please try again");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("It seems like you input was not in a correct, please try again.");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("It seems like you tried to devide by zero, please try again.");
            }
            catch (QuinshiftAcademyExeption ex)
            {
                Console.WriteLine($"Out custom exeption was catched...{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some weird error happened, please try again");
            }
            finally
            {
                //Console.WriteLine("THIS PART OF THE CODE WILL ALWAYS EXECUTE");
            }
            

            Console.WriteLine("The code reached this line ::::::::::");
        }

        static double SquareRoot(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Ne mozemo korenovati negativne brojeve");
                throw new Exception("Korenje sa negativnim brojevima je zabranjeno");
            }

            return Math.Sqrt(x);
        }
    }
}
