using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Coin values in cents.
            int goldValue = 10;
            int silverValue = 5;

            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("\nPlease enter the amount to convert:");

            // User inputs the amount to convert.
            string input = Console.ReadLine();
            double amountToConvert;

            // Error handling.
            while (!double.TryParse(input, out amountToConvert) || amountToConvert < 0)
            {
                Console.WriteLine("Please enter a valid number:");
                input = Console.ReadLine();
            }

            // Convert to whole cents.
            amountToConvert = Math.Floor(amountToConvert);
            int remainder = (int)amountToConvert;

            // Find the maximum amount of gold coins that fits into the amount input by the user.
            int goldCoins = remainder / goldValue;

            // Find the remaining amount. (gold)
            remainder %= goldValue;

            // Find the maximum amount of silver coins that fits into the amount input by the user.
            int silverCoins = remainder / silverValue;

            // Find the remaining amount. (silver)
            remainder %= silverValue;

            // Each bronze coin is worth 1 cent so it is equal to the remainder.
            int bronzeCoins = remainder;

            //Write these outputs to the console.
            Console.WriteLine($"\n{(int)amountToConvert} cents is equal to...");
            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {bronzeCoins}");
        }
    }
}
