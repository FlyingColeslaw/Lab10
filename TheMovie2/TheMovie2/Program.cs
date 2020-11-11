using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable11
{
    class MainClass
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Appliaction!");
            Console.WriteLine("There are 10 Movies in this list.");
            
            while (true)
            { 

            Console.WriteLine("What category are you interested in:");
            Console.WriteLine("Horror");
            Console.WriteLine("Drama");
            Console.WriteLine("Sci-Fi");
            Console.WriteLine("Animation");

            string mySearchString = Console.ReadLine();





            List<Movie> allMovies = new List<Movie>();



            Movie sawOne = new Movie("Saw 1", "Horror");
            Movie sawTwo = new Movie("Saw 2", "Horror");
            Movie theAvengers = new Movie("Avengers", "Drama");
            Movie theFight = new Movie("Fight Club", "Drama");
            Movie theLooper = new Movie("Looper", "Sci-Fi");
            Movie theVR = new Movie(" Ready Player One", "Sci-Fi");
            Movie theTS = new Movie("Toy Story 1", "Animation");
            Movie theTS2 = new Movie("Toy Story 2", "Animation");
            Movie theTS3 = new Movie("Toy Story 3", "Animation");
            Movie theTS4 = new Movie("Toy Story 4", "Animation");

            allMovies.Add(sawOne);
            allMovies.Add(sawTwo);
            allMovies.Add(theAvengers);
            allMovies.Add(theFight);
            allMovies.Add(theLooper);
            allMovies.Add(theVR);
            allMovies.Add(theTS);
            allMovies.Add(theTS2);
            allMovies.Add(theTS3);
            allMovies.Add(theTS4);

                

                Console.WriteLine("Do ytou want to continue? (Y/N)");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "N" || UserInput2 == "n")
                    break;

                foreach (Movie currentMovie in allMovies)
                {
                    if (currentMovie.getCategory() == mySearchString)
                    {
                        Console.WriteLine(currentMovie.getTitle());
                    }

                    

                }

            }

        }

       




        public class Movie
        {

           


            public Movie(string title, string category)
            {
                _title = title;
                _category = category;
            }

            private string _title;
            private string _category;

            public string getTitle()
            {
                return _title;
            }
            public string getCategory()
            {
                return _category;
            }

           
        }


    }
}
