using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheMovie1
{


    public class MyList<T> { }
    public class TestList<T> { }

    class MyList
    {
        public static void Main()
        {
            List<string> items = new List<string>() {
                  "1: The Ring; The Ring 2",
                  "2: Avengers End Game; Fight Club",
              "3: Looper; Ready Player One",
               "4: Toy Story 1; Toy Story 2; Toy Stoy 3; Toy Story 4",
            
        };

            Console.WriteLine("Welcome to the Movie List Appliaction!");
            Console.WriteLine("There are 10 Movies in this list.");

            while (true)
            {     
                
               
                Console.WriteLine("What category are you interested in: Enter Number 1-4?");
                Console.WriteLine("1. Horror");
                Console.WriteLine("2. Drama");
                Console.WriteLine("3. Sci-Fi");
                Console.WriteLine("4. Amimation");
                Console.WriteLine("Please press enter to quit");

                string mySearchString = Console.ReadLine();

                if (string.IsNullOrEmpty(mySearchString))
                    break;
                


                foreach (var item in items.Where(r => r.IndexOf(mySearchString) == 0))
                    Console.WriteLine(item);
                {
                    Console.WriteLine("Do you want to continue? (Y/N)");
                    string UserInput = Console.ReadLine();

                    if (UserInput == "N" || UserInput == "n")
                        break;


                }
            }

                Console.WriteLine();
            }
        }
    }

