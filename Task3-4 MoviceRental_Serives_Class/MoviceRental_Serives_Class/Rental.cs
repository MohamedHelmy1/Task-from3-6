using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviceRental_Serives_Class
{
    public class Rental
    {
        public Movie RentedMovie { get; private set; }
        public Customer RentingCustomer { get; private set; }
        public DateTime RentalDate { get; private set; }

        // Constructor to initialize the rental transaction
        public Rental(Movie movie, Customer customer)
        {
            RentedMovie = movie;
            RentingCustomer = customer;
            RentalDate = DateTime.Now;
        }

        // Method to display rental details
        public void DisplayRentalInfo()
        {
            Console.WriteLine($"Rental Information:");
            Console.WriteLine($"Movie: {RentedMovie.Title}, Rented by: {RentingCustomer.Name}, Rental Date: {RentalDate}");
        }
    }
}
