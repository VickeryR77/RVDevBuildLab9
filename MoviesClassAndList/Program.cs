using System;
using System.Collections.Generic;

namespace MoviesClassAndList
{

    class Movie
    { 
        private string _title;
        public string Title { get { return _title; } set { _title = value; } }
        private string _category;
        public string Category { get { return _category; } set { _category = value; } }

        public Movie(string thetitle, string thecategory)
        {
            _title = thetitle;
            _category = thecategory;
        }

        public string GetCategory()
        {
            return Category;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string entry)
        {
            Title = entry;
        }

        public void SetCategory(string entry)
        {
            Category = entry;
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> MovieList = new List<Movie>();

            Movie movie = new Movie("The Road to El Dorado", "Animated");
            MovieList.Add(movie);

            Movie movie2 = new Movie("Starship Troopers", "Sci-Fi");
            MovieList.Add(movie2);

            Movie movie3 = new Movie("Underwater", "Horror");
            MovieList.Add(movie3);

            Movie movie4 = new Movie("Howl's Moving Castle", "Animated");
            MovieList.Add(movie4);

            Movie movie5 = new Movie("Alien", "Sci-Fi");
            MovieList.Add(movie5);

            Movie movie6 = new Movie("Sinister", "Horror");
            MovieList.Add(movie6);

            Movie movie7 = new Movie("Pulp Fiction", "Drama");
            MovieList.Add(movie7);

            Movie movie8 = new Movie("Fantastic Planet", "Animated");
            MovieList.Add(movie8);

            Movie movie9 = new Movie("Starwars", "Sci-Fi");
            MovieList.Add(movie9);

            Movie movie10 = new Movie("It", "Horror");
            MovieList.Add(movie10);

            Movie movie11 = new Movie("The Shawshank Redemption", "Drama");
            MovieList.Add(movie11);

            Movie movie12 = new Movie("Ponyo", "Animated");
            MovieList.Add(movie12);

            Movie movie13 = new Movie("Serenity", "Sci-Fi");
            MovieList.Add(movie13);

            Movie movie14 = new Movie("In the Mouth of Madness", "Horror");
            MovieList.Add(movie14);

            Movie movie15 = new Movie("Good Will Hunting", "Drama");
            MovieList.Add(movie15);

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("What category of movie are you interested in checking out?");
                Console.WriteLine("|********************************************************|");
                Console.WriteLine("|      Animated  |     Drama  |    Horror   |    SciFi   |");
                Console.WriteLine("|********************************************************|");

                string entry = Console.ReadLine().ToLower();
                Console.WriteLine("");
                
                while (entry != "animated" && entry != "drama" && entry != "horror" && entry != "scifi")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("That is not a valid category. Please select one from below.");
                    Console.WriteLine("|********************************************************| ");
                    Console.WriteLine("|      Animated  |     Drama  |    Horror   |    SciFi   | ");
                    Console.WriteLine("|********************************************************| ");

                    entry = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

                MovieList.to();

                foreach (Movie film in MovieList)
                {

                    if (entry == "animated" && film.Category == "Animated")
                    {
                        Console.WriteLine($"{film.Title,-23}{film.Category,20}");
                    }
                    if (entry == "drama" && film.Category == "Drama")
                    {
                        Console.WriteLine($"{film.Title,-24}{film.Category,20}");
                    }
                    if (entry == "scifi" && film.Category == "Sci-Fi")
                    {
                        Console.WriteLine($"{film.Title,-20}{film.Category,20}");
                    }
                    if (entry == "horror" && film.Category == "Horror")
                    {
                        Console.WriteLine($"{film.Title,-23}{film.Category,20}");
                    }
                }
                GetRepeat(out running);

            }
        }
        public static void GetRepeat(out bool running)
        {
            running = true;
            bool runningAgain = true;
            while (runningAgain == true)
            {

                Console.WriteLine("");
                Console.WriteLine("Would you like to continue? (Y/N)");

                string exitEntry = Console.ReadLine().ToLower();

                if (exitEntry == "y")
                {
                    break;
                }
                else if (exitEntry == "n")
                {
                    running = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

    }

    }
