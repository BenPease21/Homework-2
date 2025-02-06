using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
            "The following items are available:\n" +
            "1 – Rope\n" +
            "2 – Torches\n" +
            "3 – Climbing Equipment\n" +
            "4 – Clean Water\n" +
            "5 – Machete\n" +
            "6 – Canoe\n" +
            "7 – Food Supplies\n" +
            "What is your name? (Discount name is \"Ben\" btw) \n"
             );
            double Discount = 1;

            string FirstName;
            FirstName = Console.ReadLine();
            if (FirstName == "Ben") { Discount = .5; }
            else { Discount = 1; }

            Console.WriteLine("What number do you want to see the price of?\n");

            string Response;
            Response = Console.ReadLine();

            if (Response == "1") { Console.WriteLine(10*Discount +" Gold"); }
            else if (Response == "2") { Console.WriteLine(16*Discount +" Gold"); }
            else if (Response == "3") { Console.WriteLine(24 * Discount + " Gold"); }
            else if (Response == "4") { Console.WriteLine(2 * Discount + "Gold"); }
            else if (Response == "5") { Console.WriteLine(20 * Discount + " Gold"); }
            else if (Response == "6") { Console.WriteLine(200 * Discount + " Gold"); }
            else if (Response == "7") { Console.WriteLine(2 * Discount + " Gold"); }
        }

    }
}
