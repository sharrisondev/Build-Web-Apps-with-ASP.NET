using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExpeditionBooleanAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAtmosphereBreathable = true;
            bool isGravityStable = false;
            bool resourcesSufficient = true;
            int currentCrew = 5;
            int maxCrewCapacity = 10;

            bool isHabitable = isAtmosphereBreathable && isGravityStable;
            Console.WriteLine(isHabitable);

            bool suitableForExpansion = isGravityStable || resourcesSufficient;
            Console.WriteLine(suitableForExpansion);

            bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;
            Console.WriteLine(canAcceptMoreCrew);
        }
    }
}
