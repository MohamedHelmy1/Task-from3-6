using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviceRental_Serives_Class
{
    public class RentalStore
    {

        private List<Movie> movies;
        private List<Customer> customers;

        // Constructor to initialize the rental store
        public RentalStore()
        {
            movies = new List<Movie>();
            customers = new List<Customer>();
        }

        // Method to add a movie to the store
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine($"Movie '{movie.Title}' added to the store.");
        }

        // Method to add a customer to the store
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"Customer '{customer.Name}' added to the store.");
        }

        // Method to find a movie by title
        public Movie FindMovie(string title)
        {
            foreach (var movie in movies)
            {
                if (movie.Title == title)
                {
                    return movie;
                }
            }
            return null;
        }

        // Method to find a customer by ID
        public Customer FindCustomer(int customerID)
        {
            foreach (var customer in customers)
            {
                if (customer.CustomerID == customerID)
                {
                    return customer;
                }
            }
            return null;
        }

        // Method to display all available movies
        public void DisplayAvailableMovies()
        {
            Console.WriteLine("Available Movies:");
            foreach (var movie in movies)
            {
                if (movie.IsAvailable)
                {
                    movie.DisplayMovieInfo();
                }
            }
        }

        // Method to rent a movie to a customer
        public void RentMovie(int customerID, string movieTitle)
        {
            Movie movie = FindMovie(movieTitle);
            Customer customer = FindCustomer(customerID);

            if (movie != null && customer != null)
            {
                customer.RentMovie(movie);
            }
            else
            {
                Console.WriteLine("Invalid customer ID or movie title.");
            }
        }

        // Method to return a movie from a customer
        public void ReturnMovie(int customerID, string movieTitle)
        {
            Movie movie = FindMovie(movieTitle);
            Customer customer = FindCustomer(customerID);

            if (movie != null && customer != null)
            {
                customer.ReturnMovie(movie);
            }
            else
            {
                Console.WriteLine("Invalid customer ID or movie title.");
            }
        }
    }
}
