using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviceRental_Serives_Class
{
    public class Movie
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public bool IsAvailable { get; private set; }

        // Constructor to initialize the movie
        public Movie(string title, string genre)
        {
            Title = title;
            Genre = genre;
            IsAvailable = true; // Initially, the movie is available
        }

        // Method to rent the movie
        public void RentMovie()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Sorry, {Title} is already rented.");
            }
        }

        // Method to return the movie
        public void ReturnMovie()
        {
            IsAvailable = true;
        }

        // Method to display movie details
        public void DisplayMovieInfo()
        {
            Console.WriteLine($"Title: {Title}, Genre: {Genre}, Available: {IsAvailable}");
        }

    }
}
