using MusicManagementApp.Enums;
using System.Data;

namespace MusicManagementApp.Models
{
    public class Song
    {
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, int lengthInSeconds, Genre genre)
        {
            Title = title;
            Length = TimeSpan.FromSeconds(lengthInSeconds);
            Genre = genre;
        }
    }
}
