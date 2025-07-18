using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating varibles.
            string passengerName = "Zara";
            int passengerAge = 28;
            string ticketType = "First Class";
            string preferredPlanet = "Mars";

            // Prints the variables to console.
            Console.WriteLine("Passenger name: " + passengerName);
            Console.WriteLine("Passenger age: " + passengerAge);
            Console.WriteLine("Ticket type: " + ticketType);
            Console.WriteLine("Preferred planet: " + preferredPlanet);

            //Increment the age by 1 and prints to console.
            passengerAge++;
            Console.WriteLine("Corrected passengers age: " + passengerAge);

            // Explicitly convert the passengerAge to a double.
            double passengerAgeDouble = (double)passengerAge;
            Console.WriteLine("Explicitly convert to a double: " + passengerAgeDouble);

            // Implicitly convert the passengerAge to a double.
            double passengerAgeDouble2 = passengerAge;
            Console.WriteLine("Implicitly convert to a double: " + passengerAgeDouble2);

            // Convert the passengerAge to a string.
            string passengerAgeString = Convert.ToString(passengerAge);
            Console.WriteLine("Converting to string: " + passengerAgeString);
        }
    }
}
