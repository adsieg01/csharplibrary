using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectProjects
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Object Instantiation
            Netflix starTrek = new Netflix();
            Netflix familyGuy = new Netflix();
            Netflix narcos = new Netflix();

            // Set Object Values
            starTrek.Name = "Star Trek Enterprise";
            starTrek.Genre = "Scifi";
            starTrek.Rating = 3;

            familyGuy.Name = "Family Guy";
            familyGuy.Genre = "Comedy";
            familyGuy.Rating = 4;

            narcos.Name = "Narcos";
            narcos.Genre = "Drama";
            narcos.Rating = 5;


            // Calling the methods on the object 

            //starTrek.GetSuggestion();
            //familyGuy.GetSuggestion();
            //narcos.GetSuggestion();

            //Creating a list of Objects
            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(starTrek);
            favoriteShows.Add(familyGuy);
            favoriteShows.Add(narcos);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                Console.WriteLine(show.Genre);
                Console.WriteLine(show.Rating);
            }



            
            




        }

        }
}
