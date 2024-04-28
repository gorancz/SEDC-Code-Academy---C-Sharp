using MovieTheaterManagement.Enums;
namespace MovieTheaterManagement.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new Exception("Rating must be a number from 1 to 5.");
            }

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }
        public void Play()
        {
            Console.WriteLine($"Now playing: {Title}");
        }
    }
}
