// Written by Ben Pease


using System.Runtime.InteropServices;

namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AirshipNum=0;
            int HunterNum=0;
            int HUnterGuess;

            Console.Write("User 1, enter a number between 0 and 100: ");
            AirshipNum=Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x <= 30; x++)
            {
                Console.WriteLine("\n");
            }

            Console.WriteLine("User 2, guess the number");
            while (true)
            {
             HunterNum=Convert.ToInt32(Console.ReadLine());
                if (HunterNum > AirshipNum) { Console.WriteLine($"{HunterNum} is too high."); }
                else if (HunterNum < AirshipNum) { Console.WriteLine($"{HunterNum} is too low."); }
                else if (HunterNum == AirshipNum) { Console.WriteLine($"You guessed the number!"); break; }
                Console.WriteLine("What is your next guess?");
            }
        }
    }
}
