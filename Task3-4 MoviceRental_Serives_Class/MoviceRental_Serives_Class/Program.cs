using MoviceRental_Serives_Class;

RentalStore rentalStore = new RentalStore();

// Adding movies to the store
rentalStore.AddMovie(new Movie("Inception", "Sci-Fi"));
rentalStore.AddMovie(new Movie("The Godfather", "Crime"));
rentalStore.AddMovie(new Movie("Interstellar", "Sci-Fi"));

// Adding customers
rentalStore.AddCustomer(new Customer("John Doe", 101));
rentalStore.AddCustomer(new Customer("Jane Smith", 102));

// Renting a movie
rentalStore.RentMovie(101, "Inception");
rentalStore.RentMovie(102, "Interstellar");

// Display available movies
rentalStore.DisplayAvailableMovies();

// Returning a movie
rentalStore.ReturnMovie(101, "Inception");

// Display available movies after returning
rentalStore.DisplayAvailableMovies();