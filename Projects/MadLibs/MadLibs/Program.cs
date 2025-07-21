using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            This program writes a Mad Libs word game! The user will be prompted to enter a name, adjectives, nouns, a verb, and other words to fill in the blanks of a funny story.
            Author: Shaun H
            */

            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting!");


            // Give the Mad Lib a title:
            string title = "Jeremy's day";
            Console.WriteLine(title);

            // Define user input and variables:

            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Someone";
            }
            name = char.ToUpper(name[0]) + name.Substring(1);

            // Getadjectives.
            Console.Write("Enter a first adjective: ");
            string adj1 = Console.ReadLine();
            Console.Write("Enter a second adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter a third adjective: ");
            string adj3 = Console.ReadLine();

            // Get verb
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            // Get nouns.
            Console.Write("Enter a first noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter a second noun: ");
            string noun2 = Console.ReadLine();

            // Asks for the various inputs listed in the task.
            Console.Write("Enter a animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:
            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);
            Console.WriteLine("\nThanks for playing Mad Libs!");
        }
    }
}
