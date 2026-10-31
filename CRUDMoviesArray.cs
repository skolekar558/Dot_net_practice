using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class CRUDMoviesArray
    { 
            static void Main(string[] args)
            {
                int option;

                MovieArray movies = new MovieArray();

                do
                {
                    Console.WriteLine("Enter a Proper Option : \n1.Insert Movie\n2.Update Movie\n3.Delete Movie\n4.Search Movie By Id\n5.Display Movie By Name\n6.Show All Movies\n7.Exist !");
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter a Movie ID : ");
                            int movieId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter a Movie Name : ");
                            string movieName = Console.ReadLine();
                            Console.WriteLine("Enter a Ticket Price : ");
                            double ticketprice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter a Producer Name : ");
                            string producer = Console.ReadLine();
                            string response = movies.InsertMovie(new Movie(movieId, movieName, ticketprice, producer));
                            Console.WriteLine(response);
                            break;

                        case 2:
                            Console.WriteLine("Enter a Movie ID for Update : ");
                            int updateId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter a New Movie Name : ");
                            string newName = Console.ReadLine();
                            Console.WriteLine("Enter a New Ticket Price : ");
                            double newprice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter a New Producer Name : ");
                            string newproducer = Console.ReadLine();
                            movies.UpdateMovie(updateId, new Movie(updateId, newName, newprice, newproducer));
                            break;

                        case 3:
                            Console.WriteLine("Enter a Movie ID for Delete : ");
                            int deleteId = Convert.ToInt32(Console.ReadLine());
                            movies.DeleteMovie(deleteId);
                            break;

                        case 4:
                            Console.WriteLine("Enter a Movie ID for Display : ");
                            int displayId = Convert.ToInt32(Console.ReadLine());
                            movies.DisplayByID(displayId);
                            break;

                        case 5:
                            Console.WriteLine("Enter a Movie Name : ");
                            string name = Console.ReadLine();
                            movies.SearchByName(name);
                            break;

                        case 6:
                            Console.WriteLine("Display All Movies : ");
                            movies.DisplayAllMovies();
                            break;



                        case 7:
                            Console.WriteLine("Existing....!!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 to 7 ");
                            break;

                    }
                } while (option != 7);

            }
        }

    }


