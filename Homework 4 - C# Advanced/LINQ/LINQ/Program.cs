using LINQ.Models;
using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>
        {
            new Person { FirstName = "Alice", LastName = "Smith", Age = 25, Country = "USA", Hobbies = new List<string> { "Reading", "Hiking" } },
            new Person { FirstName = "Bob", LastName = "Johnson", Age = 30, Country = "Canada", Hobbies = new List<string> { "Cooking", "Painting" } },
            new Person { FirstName = "Charlie", LastName = "Brown", Age = 22, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
            new Person { FirstName = "David", LastName = "Wilson", Age = 27, Country = "USA", Hobbies = new List<string> { "Photography", "Gardening" } },
            new Person { FirstName = "Emily", LastName = "Davis", Age = 28, Country = "Canada", Hobbies = new List<string> { "Traveling", "Yoga" } },
            new Person { FirstName = "John", LastName = "Smith", Age = 35, Country = "USA", Hobbies = new List<string> { "Reading", "Cooking", "Hiking" } },
            new Person { FirstName = "Jane", LastName = "Doe", Age = 32, Country = "Canada", Hobbies = new List<string> { "Reading", "Gaming" } },
            new Person { FirstName = "Michael", LastName = "Brown", Age = 24, Country = "UK", Hobbies = new List<string> { "Swimming", "Hiking" } },
            new Person { FirstName = "Daniel", LastName = "Wilson", Age = 30, Country = "USA", Hobbies = new List<string> { "Gardening" } },
            new Person { FirstName = "Emma", LastName = "Johnson", Age = 29, Country = "Canada", Hobbies = new List<string> { "Yoga", "Cooking" } },
            new Person { FirstName = "Olivia", LastName = "Smith", Age = 23, Country = "USA", Hobbies = new List<string> { "Reading", "Gardening" } },
            new Person { FirstName = "James", LastName = "Davis", Age = 26, Country = "Canada", Hobbies = new List<string> { "Traveling" } },
            new Person { FirstName = "Noah", LastName = "Brown", Age = 29, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
            new Person { FirstName = "Ella", LastName = "Wilson", Age = 28, Country = "USA", Hobbies = new List<string> { "Photography", "Cooking" } },
            new Person { FirstName = "Liam", LastName = "Davis", Age = 31, Country = "Canada", Hobbies = new List<string> { "Reading", "Yoga" } }
        };

            Console.WriteLine("Persons from the USA:");

            List<Person> personsFromUSA = personList
                .Where(person => person.Country == "USA")
                .ToList();

            foreach (Person person in personsFromUSA)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Hobbies: {string.Join(", ", person.Hobbies)}");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("The oldest person:");

            Person oldestPerson = personList
                .OrderByDescending(person => person.Age)
                .FirstOrDefault();

            Console.WriteLine($"The oldest person is {oldestPerson.FirstName} {oldestPerson.LastName} from {oldestPerson.Country}, aged {oldestPerson.Age}. Their hobbies are {string.Join(", ", oldestPerson.Hobbies)}.");


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Average age of all persons:");

            double averageAge = personList
                .Average(person => person.Age);

            Console.WriteLine($"The average age of all persons is {averageAge}.");


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("All persons names starting with letter 'J':");

            List<Person> personsStartingWithJ = personList
                .Where(person => person.FirstName
                .StartsWith("J"))
                .ToList();

            foreach (Person person in personsStartingWithJ)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
            }

            Console.WriteLine("-------------------------------------");


            Console.WriteLine("The three youngest person:");

            List<Person> threeYoungestPersons = personList
                .OrderBy(person => person.Age)
                .Take(3)
                .ToList();

            foreach (Person person in threeYoungestPersons)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
            }


                Console.WriteLine("-------------------------------------");


            Console.WriteLine("Persons with 'Reading' hobbies:");


            List<Person> personsWithReadingAsHobby = personList
                .Where(person => person.Hobbies
                .Contains("Reading"))
                .ToList();

            if (personsWithReadingAsHobby.Any())
            {
                foreach (Person person in personsWithReadingAsHobby)
                {
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
                }
            }
            else
            {
                Console.WriteLine("No, there is no person who has 'Reading' as a hobby.");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("The unique countries:");

            List<string> uniqueCountries = personList
                .Select(person => person.Country)
                .Distinct()
                .ToList();

            Console.WriteLine("The unique countries in the list are " + string.Join(", ", uniqueCountries));


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Persons by their age:");

            List<Person> sortedPersons = personList
                .OrderBy(person => person.Age)
                .ToList();

            foreach (Person person in sortedPersons)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("30 years old persons:");

            List<Person> personsWhoAre30 = personList
                .Where(person => person.Age == 30)
                .ToList();

            foreach (Person person in personsWhoAre30)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Persons from the UK:");

            List<Person> personsFromUK = personList
                .Where(person => person.Country == "UK")
                .ToList();

            foreach (Person person in personsFromUK)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Hobbies: {string.Join(", ", person.Hobbies)}");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Persons with at least one hobby:");

            List<Person> personsWithAtLeastOneHobby = personList
                .Where(person => person.Hobbies.Any())
                .ToList();

            if (personsWithAtLeastOneHobby.Any())
            {
                foreach (Person person in personsWithAtLeastOneHobby)
                {
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
                }
            }
            else
            {
                Console.WriteLine("No, not all persons have at least one hobby.");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Persons with both 'Singing' and 'Dancing' as hobbies:");

            List<Person> personsWithSingingAndDancing = personList
                .Where(person => person.Hobbies
                .Contains("Singing") && person.Hobbies
                .Contains("Dancing"))
                .ToList();
            if (personsWithSingingAndDancing.Any())
            {
                foreach (Person person in personsWithSingingAndDancing)
                {
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}, Country: {person.Country}, Hobbies: {string.Join(", ", person.Hobbies)}");
                }
            }
            else
            {
                Console.WriteLine("No, they are not persons in the list with 'Singing' and 'Dancing' as hobbies.");
            }


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Persons with the longest first and last names:");

            Person personWithLongestFirstName = personList
                .OrderByDescending(person => person.FirstName.Length)
                .FirstOrDefault();

            Person personWithLongestLastName = personList
                .OrderByDescending(person => person.LastName.Length)
                .FirstOrDefault();

            Console.WriteLine($"The person with the longest first name is {personWithLongestFirstName.FirstName} {personWithLongestFirstName.LastName}, Age: {personWithLongestFirstName.Age}, Country: {personWithLongestFirstName.Country}, Hobbies: {string.Join(", ", personWithLongestFirstName.Hobbies)}.");
            Console.WriteLine($"The person with the longest last name is {personWithLongestLastName.FirstName} {personWithLongestLastName.LastName}, Age: {personWithLongestLastName.Age}, Country: {personWithLongestLastName.Country}, Hobbies: {string.Join(", ", personWithLongestLastName.Hobbies)}.");


            Console.WriteLine("-------------------------------------");


            Console.WriteLine("Full names persons from the list:");

            List<string> fullNames = personList
                .Select(person => $"{person.FirstName} {person.LastName}")
                .ToList();

            foreach (string fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }
        }
    }
}
