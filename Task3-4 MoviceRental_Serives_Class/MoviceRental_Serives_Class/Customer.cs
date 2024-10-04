using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviceRental_Serives_Class
{
    public class Customer
    {
        public string Name { get; private set; }
        public int CustomerID { get; private set; }
        public List<Movie> RentedMovies { get; private set; }

        // Constructor to initialize the customer
        public Customer(string name, int customerID)
        {
            Name = name;
            CustomerID = customerID;
            RentedMovies = new List<Movie>();
        }

        // Method to rent a movie
        public void RentMovie(Movie movie)
        {
            if (movie.IsAvailable)
            {
                movie.RentMovie();
                RentedMovies.Add(movie);
                Console.WriteLine($"{Name} has rented the movie: {movie.Title}");
            }
            else
            {
                Console.WriteLine($"{movie.Title} is not available for rent.");
            }
        }

        // Method to return a movie
        public void ReturnMovie(Movie movie)
        {
            if (RentedMovies.Contains(movie))
            {
                movie.ReturnMovie();
                RentedMovies.Remove(movie);
                Console.WriteLine($"{Name} has returned the movie: {movie.Title}");
            }
            else
            {
                Console.WriteLine($"{Name} did not rent the movie: {movie.Title}");
            }
        }

        // Method to display customer details
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerID}, Name: {Name}");
            Console.WriteLine("Rented Movies:");
            foreach (var movie in RentedMovies)
            {
                Console.WriteLine($" - {movie.Title}");
            }
        }
    }
}
