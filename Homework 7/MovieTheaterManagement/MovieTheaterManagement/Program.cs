using MovieTheaterManagement.Enums;
using MovieTheaterManagement.Models;

namespace MovieTheaterManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
    {
        new Movie("Wonka", Genre.Comedy, 5),
        new Movie("Chucky", Genre.Horror, 4),
        new Movie("Fallout", Genre.Action, 3),
        new Movie("The Sympathizer", Genre.Drama, 2),
        new Movie("Transformers One", Genre.SciFi, 1),
        new Movie("Deadpool & Wolverine", Genre.Comedy, 5),
        new Movie("Alien: Romulus", Genre.Horror, 4),
        new Movie("Civil War", Genre.Action, 3),
        new Movie("Oppenheimer", Genre.Drama, 2),
        new Movie("Interstellar", Genre.SciFi, 1)
    };

            Cinema cinestar = new Cinema("Cinestar", 5, movies);
            Cinema cineplexx = new Cinema("Cineplexx", 3, movies);
            Cinema pathe = new Cinema("Pathe", 2, movies);

            while (true)
            {
                Console.WriteLine("Please choose a cinema:");
                Console.WriteLine("1. Cinestar");
                Console.WriteLine("2. Cineplexx");
                Console.WriteLine("3. Pathe");
                Console.WriteLine("0. Exit");

                string cinemaChoice = Console.ReadLine();

                try
                {
                    switch (cinemaChoice)
                    {
                        case "1":
                            HandleCinema(cinestar);
                            break;
                        case "2":
                            HandleCinema(cineplexx);
                            break;
                        case "3":
                            HandleCinema(pathe);
                            break;
                        case "0":
                            return; 
                        default:
                            throw new Exception("Error! Invalid choice for cinema selection.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
        static void HandleCinema(Cinema cinema)
        {
            Console.WriteLine($"You have chosen {cinema.Name}.");
            Console.WriteLine("Would you like to see all movies or by genre?");
            Console.WriteLine("1. All movies");
            Console.WriteLine("2. By genre");

            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    ShowAllMovies(cinema);
                    break;
                case "2":
                    ShowMoviesByGenre(cinema);
                    break;
                default:
                    throw new Exception("Invalid choice. Please enter 1 or 2.");
            }
        }

        static void ShowAllMovies(Cinema cinema)
        {
            Console.WriteLine("All Movies:");
            for (int i = 0; i < cinema.ListOfMovies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cinema.ListOfMovies[i].Title}");
            }

            Console.WriteLine("Please choose a movie by a number:");
            int movieIndex = int.Parse(Console.ReadLine()) - 1;

            if (movieIndex >= 0 && movieIndex < cinema.ListOfMovies.Count)
            {
                cinema.ListOfMovies[movieIndex].Play();
            }
            else
            {
                throw new Exception("Invalid movie index.");
            }
        }

        static void ShowMoviesByGenre(Cinema cinema)
        {
            Console.WriteLine("Please enter your favorite genre:");
            Console.WriteLine("1. Comedy");
            Console.WriteLine("2. Horror");
            Console.WriteLine("3. Action");
            Console.WriteLine("4. Drama");
            Console.WriteLine("5. Sci-Fi");

            string genreChoice = Console.ReadLine();

            Genre selectedGenre;
            switch (genreChoice)
            {
                case "1":
                    selectedGenre = Genre.Comedy;
                    break;
                case "2":
                    selectedGenre = Genre.Horror;
                    break;
                case "3":
                    selectedGenre = Genre.Action;
                    break;
                case "4":
                    selectedGenre = Genre.Drama;
                    break;
                case "5":
                    selectedGenre = Genre.SciFi;
                    break;
                default:
                    throw new Exception("Invalid genre choice.");
            }

            Console.WriteLine($"Movies in {selectedGenre} genre:");
            int count = 0;
            for (int i = 0; i < cinema.ListOfMovies.Count; i++)
            {
                if (cinema.ListOfMovies[i].Genre == selectedGenre)
                {
                    Console.WriteLine($"{++count}. {cinema.ListOfMovies[i].Title}");
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No movies found in the selected genre.");
                return;
            }

            Console.WriteLine("Please choose a movie by a number:");
            int movieIndex = int.Parse(Console.ReadLine()) - 1;

            if (movieIndex >= 0 && movieIndex < cinema.ListOfMovies.Count)
            {
                cinema.ListOfMovies[movieIndex].Play();
            }
            else
            {
                throw new Exception("Invalid movie index.");
            }
        }
    }
}
