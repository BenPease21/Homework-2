using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

//Written by Ben Pease

namespace Buying_Inventory
{
    class BuyingInventory
    {
        static void Main()
        {
            Console.WriteLine
            ("The following items are available:\n" +
              "1 – Rope\n" +
              "2 – Torches\n" +
              "3 – Climbing Equipment\n" +
              "4 – Clean Water\n" +
              "5 – Machete\n" +
              "6 – Canoe\n" +
              "7 – Food Supplies\n");

            string response;
            double Discount = 1;
            string FirstName;
            string Selection;
            
            Console.Write("What is your name? ");
            FirstName = Console.ReadLine();

            if (FirstName == "Ben") { Discount = .5; }
            
            Console.Write("What number do you want to see the price of? ");
            Selection = Console.ReadLine();

            response = Selection switch
            {
                "1" => $"Rope costs {10 * Discount}",
                "2" => $"Torches cost {16 * Discount}",
                "3" => $"Climbing Equipment costs {24 * Discount }",
                "4" => $"Clean Water costs {2 * Discount}",
                "5" => $"A Machete costs {20 * Discount}",
                "6" => $"A Canoe costs {200 * Discount }",
                "7" => $"Food Supplies costs {2 * Discount}",
                _ => $"Buying nothing will cost you {0 * Discount}",
            };

            Console.Write($"\n{response} Gold\n\n" );

        }
    }
}
