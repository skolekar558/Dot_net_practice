using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public  class Movie
    {
            public int MovieId { get; set; }
            public string MovieName { get; set; }
            public double TicketCost { get; set; }
            public string ProducerName { get; set; }

            public Movie()
            {

            }
            public Movie(int movieId, string name, double ticketprice, string producerName)
            {
                MovieId = movieId;
                MovieName = name;
                TicketCost = ticketprice;
                ProducerName = producerName;
            }

            public override string ToString()
            {
                return $"Movie ID : {MovieId}\nMovie Name : {MovieName}\nTicket Cost : {TicketCost}\nProducer Name : {ProducerName}";
            }
        }

        public class MovieArray
        {
            private int size;
            private Movie[] movies;
            private const int Capacity = 10;

            public MovieArray()
            {
                movies = new Movie[Capacity];
                size = 0;
            }

            public string InsertMovie(Movie movie)
            {
                if (movies.Length <= size)
                {
                    Array.Resize(ref movies, movies.Length + Capacity);
                }

                movies[size++] = movie;
                return "\nMovie Inserted Successfully.\n";
            }

            public void DisplayByID(int movieId)
            {

                for (int i = 0; i < size; i++)
                {
                    if (movies[i].MovieId == movieId)
                    {

                        Console.WriteLine($"\nMovie ID : {movies[i].MovieId} \nMovie Name : {movies[i].MovieName} \nTicket Cost : {movies[i].TicketCost}\nProducer Name : {movies[i].ProducerName}\n");
                        return;
                    }
                }

                Console.WriteLine($"\nMovie with ID {movieId} not found.\n");

            }

            public void UpdateMovie(int movieId, Movie updatedMovie)
            {
                bool isupdate = false;
                for (int i = 0; i < size; i++)
                {
                    if (movies[i].MovieId == movieId)
                    {
                        movies[i] = updatedMovie;
                        isupdate = true;
                        if (isupdate)
                        {
                            Console.WriteLine("\nMovie Updated Successfully...\n");
                        }
                        return;
                    }
                }

                Console.WriteLine($"\nMovie with ID {movieId} not found.\n");

            }

            public void DeleteMovie(int movieId)
            {
                bool isdelete = false;

                for (int i = 0; i < size; i++)
                {
                    if (movies[i].MovieId == movieId)
                    {
                        for (int j = i; j < size; j++)
                        {
                            movies[j] = movies[j + 1];
                        }
                        size--;
                        movies[size] = null;
                        isdelete = true;
                        if (isdelete)
                        {
                            Console.WriteLine("\nMovie Deleted SuccessFully....\n");
                        }
                        return;
                    }
                }

                Console.WriteLine($"\nMovie with ID {movieId} not found.\n");
            }

            public void SearchByName(string name)
            {
                for (int i = 0; i < size; i++)
                {
                    if (movies[i].MovieName.ToLower() == name.ToLower())
                    {
                        Console.WriteLine($"Movie ID : {movies[i].MovieId} \nMovie Name : {movies[i].MovieName} \nTicket Cost : {movies[i].TicketCost}\nProducer Name : {movies[i].ProducerName}");
                        return;
                    }
                }

                Console.WriteLine($"\n Movie with Name: {name} not found.\n");
            }


public void DisplayAllMovies()
            {
                if (size == 0)
                {
                    Console.WriteLine("\nNo Movies Found Please add some Movies\n");
                }
                else
                {
                    Console.WriteLine("\nAll Movies :\n");

                    foreach (var movie in movies)
                    {
                        if (movie != null)
                        {
                            Console.WriteLine($"Movie ID : {movie.MovieId} \nMovie Name : {movie.MovieName} \nTicket Cost : {movie.TicketCost}\nProducer Name : {movie.ProducerName}");

                        }

                    }
                    Console.WriteLine();
                }

            }

        }

       

}

