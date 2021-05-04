using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4._2Movies
{
    class Movie
    {
        private string title;
        private string category;
        public Movie(string nameofmovie, string catofmovie)
        {
            title = nameofmovie;
            category = catofmovie;            
        }

        public string GetTitle()
        {
            return title;
        }
        public string GetCategory()
        {
            return category;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Movie> titles = new List<Movie>();
            titles.Add(new Movie("The Night of the Living Dead", "Horror"));
            titles.Add(new Movie("Nightmare on Elm Street", "Horror"));
            titles.Add(new Movie("The Lost Boys", "Horror"));
            titles.Add(new Movie("It", "Horror"));
            titles.Add(new Movie("American Beauty", "Drama"));
            titles.Add(new Movie("Monster", "Drama"));
            titles.Add(new Movie("Fargo", "Drama"));
            titles.Add(new Movie("Beloved", "Drama"));
            titles.Add(new Movie("Finding Nemo", "Animated"));
            titles.Add(new Movie("The Emperor's New Groove", "Animated"));
            titles.Add(new Movie("Dinosaur", "Animated"));
            titles.Add(new Movie("The Tom and Jerry Movie", "Animated"));
            titles.Add(new Movie("The Matrix", "Sci-fi"));
            titles.Add(new Movie("Galaxy Quest", "Sci-fi"));
            titles.Add(new Movie("Star Trek", "Sci-fi"));


            Console.WriteLine($"Welcome to the Blockbuster Movie List Application!");

            bool complete = false;
            while (!complete)
            {
                Console.WriteLine($"\nThere are 15 movies in this list.\nMovie categories: Animated, Drama, Horror, Sci fi.");
                Console.Write($"\nWhat category are you interested in? ");
                string choice = Console.ReadLine();

                //List<Movie> Chosen = new List<Movie>();

                if (choice != "Drama" && choice != "Animated" && choice != "Horror" && choice != "Sci fi")
                {
                    Console.WriteLine($"Sorry, {choice} is not an available category!  Please choose from the category list.\n");

                }

                foreach (Movie option in titles)
                {

                    //Console.WriteLine($"{option.GetCategory()}");


                    if (option.GetCategory() == choice)
                    {

                        Console.WriteLine($"{option.GetTitle()}");

                    }



                }

                bool done = false;
                while (!done)
                {
                    Console.Write("\nWould you like to choose another category? (Y/N) ");
                    string entry = Console.ReadLine().ToUpper();
                    if (entry == "N")
                    {
                        Console.WriteLine("Thank you for coming to Blockbuster.  Goodbye!\n");
                        complete = true;
                        break;
                    }
                    if (entry == "Y")
                    {
                        done = true;                        
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid response.");
                        done = false;
                    }
                }



            }




        }
    }
}
