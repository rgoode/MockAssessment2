using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAssessment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friend!");

            Console.WriteLine("Exercise 1 Test");
            string[] StarWarsCharacters = { "Luke Skywalker", "Princess Leia", "Yoda", "Darth Vader", "Han Solo", "R2D2", "C3PO" };
            int yodaIndex = Challenge.AddStarWarsCharacters(StarWarsCharacters);
            Console.WriteLine(yodaIndex);


            Console.WriteLine("Exercise 2 Test");
            Dictionary<string, int> deathStarDictionary = new Dictionary<string, int>()
            {
                {"Yoda", 9001 },
                {"Princess Leia", 2 },
                {"Darth Vader", 46 }
            };
            string attackValue = Challenge.DeathStarCombat(deathStarDictionary);
            Console.WriteLine(attackValue);


            Console.WriteLine("Exercise 3 Test");
            string[] Planets = new[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
            List<string> ConvertedPlanets = Challenge.ConvertPlanets(Planets);
            foreach (string planet in Planets.Reverse())
            Console.WriteLine(planet);

        }


        public class Challenge
        {

            static string[] StarWarsCharacters = { "Luke Skywalker", "Princess Leia", "Yoda", "Darth Vader", "Han Solo", "R2D2", "C3PO" };

            public static int AddStarWarsCharacters(string[] characters)
            {
                for (int characterIndex = 0; characterIndex < characters.Length; characterIndex++)
                {
                    if (characters[characterIndex] == "Yoda")
                    {
                        return characterIndex;
                    }
                }
                return -1;
            }


            public static string DeathStarCombat(Dictionary<string, int> deathStarDictionary)
            {

                string Jedi = deathStarDictionary
                    .OrderBy(StarWarsCharacter => StarWarsCharacter.Value)
                    .LastOrDefault()
                    .Key;
                return Jedi;


                // list jedis and value (lowest attack value lists first, highest attack value lists last)
            }




            static string[] Planets = new[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };


            public static List<string> ConvertPlanets(string[] planets)
            {
                List<string> ConvertedPlanets = planets.Reverse().ToList();
                return ConvertedPlanets;
            }




            public static double AverageDroid(List<int> droids)
            {
                List<int> Droids = droids.Where(droid => droid % 2 == 0).ToList();
                return Droids.Average();
            }



            public static string TryToCatchDarthVader(string CatchTheVader)
            {
                try
                {
                    int getDarth = int.Parse(CatchTheVader);
                    return "Vader was captured!";
                }
                catch
                {
                    return "Vader got away!";
                }

            }


        }

    }
}









