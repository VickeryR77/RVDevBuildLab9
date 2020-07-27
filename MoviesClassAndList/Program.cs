using System;
using System.Collections;
using System.Collections.Generic;

namespace MoviesClassAndList
{
    class Movie
    { 
        private string _title;
        public string Title { get { return _title; } set { _title = value; } }
        private string _category;
        public string Category { get { return _category; } set { _category = value; } }

        private string _runtime;

        public string RunTime { get{ return _runtime; } set{ _runtime = value; } }

        private string _yearreleased;

        public string YearReleased { get { return _yearreleased; } set { _yearreleased = value; } }

        public Movie(string thetitle, string thecategory, string theruntime, string theyearreleased)
        {
            _title = thetitle;
            _category = thecategory;
            _runtime = theruntime;
            _yearreleased = theyearreleased;
        }

        public string GetCategory()
        {
            return Category;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetRunTime()
        {
            return RunTime;
        }

        public string GetYearReleased()
        {
            return YearReleased;
        }

        public void SetTitle(string entry)
        {
            Title = entry;
        }

        public void SetCategory(string entry)
        {
            Category = entry;
        }

        public void SetRunTime(string entry)
        {
            RunTime = entry;
        }

        public void SetYearReleased(string entry)
        {
            YearReleased = entry;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {            
            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("The Road to El Dorado", "Animated","96 Minutes","2000"));
            MovieList.Add(new Movie("Starship Troopers", "Sci-Fi," ,"129 Minutes","1997"));
            MovieList.Add(new Movie("Underwater", "Horror", "95 Minutes", "2020"));
            MovieList.Add(new Movie("Howl's Moving Castle", "Animated", "119 Minutes", "2004"));
            MovieList.Add(new Movie("Alien", "Sci-Fi", "117 Minutes", "1979"));
            MovieList.Add(new Movie("Sinister", "Horror", "110 Minutes", "2012"));
            MovieList.Add(new Movie("Pulp Fiction", "Drama","178 Minutes","1994"));
            MovieList.Add(new Movie("Fantastic Planet", "Animated", "72 Minutes", "1973"));
            MovieList.Add(new Movie("Starwars", "Sci-Fi", "125 Minutes", "1977"));
            MovieList.Add(new Movie("It", "Horror", "192 Minutes", "1990"));
            MovieList.Add(new Movie("The Shawshank Redemption", "Drama", "142 Minutes", "1994"));
            MovieList.Add(new Movie("Ponyo", "Animated", "103 Minutes", "2008"));
            MovieList.Add(new Movie("Serenity", "Sci-Fi", "119 Minutes", "2005"));
            MovieList.Add(new Movie("In the Mouth of Madness", "Horror", "95 Minutes", "1994"));
            MovieList.Add(new Movie("Good Will Hunting", "Drama", "127 Minutes", "1997"));
           
            GetCategories(MovieList);
        }

        public static void GetCategories(List<Movie> MovieList)
        {

            bool running = true;
            while (running)
            {
                DrawMenuA();
                string entry = Console.ReadLine().ToLower();
                Console.WriteLine("");

                while (entry != "animated" && entry != "drama" && entry != "horror" && entry != "scifi")
                {
                    DrawMenuA();
                    entry = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

                DrawMenuB();
                foreach (Movie film in MovieList)
                {

                    if (entry == "animated" && film.Category == "Animated")
                    {
                        Console.WriteLine($"| {film.Title,-23} | {film.RunTime,12} |     {film.YearReleased,4}      | ");
                    }
                    if (entry == "drama" && film.Category == "Drama")
                    {
                        Console.WriteLine($"| {film.Title,-24} | {film.RunTime,12} |     {film.YearReleased,4}     | ");
                    }
                    if (entry == "scifi" && film.Category == "Sci-Fi")
                    {
                        Console.WriteLine($"| {film.Title,-20} | {film.RunTime,12} |       {film.YearReleased,4}       | ");
                    }
                    if (entry == "horror" && film.Category == "Horror")
                    {
                        Console.WriteLine($"| {film.Title,-23} | {film.RunTime,12} |     {film.YearReleased,4}      | ");
                    }
                }
                        Console.WriteLine("|--------------------------------------------------------|");
                GetRepeat(out running);
            }
        }

        public static void DrawMenuA() 
        {

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("What category of movie are you interested in checking out?");
            Console.WriteLine("|********************************************************|");
            Console.WriteLine("|    Animated   |    Drama   |    Horror   |     SciFi   |");
            Console.WriteLine("|********************************************************|");

        }
        public static void DrawMenuB() 
        {

            Console.Clear();
            Console.WriteLine("|********************************************************|");
            Console.WriteLine("|    Animated   |    Drama   |    Horror   |     SciFi   |");
            Console.WriteLine("|********************************************************|");
            Console.WriteLine("|--------------------------------------------------------|");

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
