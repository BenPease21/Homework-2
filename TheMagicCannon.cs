using System.Drawing;
using System.Runtime.InteropServices;

namespace TheMagicCannon
{
    internal class Program
    {

        static void SpecialShot(object Frame, string Type)
        {
         switch(Type)
         {
                case "fire":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Frame}: Fire");
                    break;
                case "electricity":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{Frame}: Electricity");
                    break;
                case "both":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{Frame}: Electric and Fire");
                    break;
         }
         Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            //Variables 
            int CrankCount;

            for (CrankCount = 1; CrankCount <= 100; CrankCount++)
            {
                if (CrankCount % 5 == 0 && CrankCount % 3 == 0)
                {
                    SpecialShot(CrankCount, "both");
                }


                else if (CrankCount % 3 == 0)
                {
                    SpecialShot(CrankCount, "fire");
                }

                else if (CrankCount % 5 == 0)
                {
                    SpecialShot(CrankCount, "electricity");
                }

                else
                {Console.WriteLine($"{CrankCount}: Normal");}

                }
            }
        }
}