using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MovieDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool goOn = true;
            Movie space = new Movie("2001 a space odyssey", "scifi");
            Movie blade = new Movie("Blade Runner", "scifi");
            Movie alien = new Movie("Alien", "scifi");
            Movie dracula = new Movie("Dracula", "horror");
            Movie ring = new Movie("The Ring", "horror");
            Movie persepolis = new Movie("Persepolis", "animated");
            Movie toy = new Movie("Toy Story", "animated");
            Movie godfather = new Movie("The Godfather", "drama");
            Movie interstellar = new Movie("Interstellar", "drama");
            Movie titanic = new Movie("Titanic", "drama");

            List<Movie> list = new List<Movie>() { space, blade, alien, dracula, ring, persepolis, toy, godfather, interstellar, titanic };
            do
            { 
            List<Movie> list2 = new List<Movie>();
            Console.WriteLine("Please choose a genre of movie to browse");
            Console.WriteLine("scifi - horror - drama - animated");
            string choice = Console.ReadLine().ToLower().Trim();
            if (choice == "scifi" || choice == "horror" || choice == "drama" || choice == "animated")
            {
                foreach (Movie item in list)
                {
                    if (item.Category.Contains(choice))
                    {
                        list2.Add(item);
                    }
                }
                foreach (Movie item in list2)
                {
                    item.ReadContent();
                }
                goOn = Continue();


            }
            else
            {
                Console.WriteLine("I didnt understand that");
                goOn = Continue();
            }
        }
            while (goOn == true);

        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to select again? y/n");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.WriteLine("I did not understand that, y or n please");
                return Continue();
            }
        }

    }
}