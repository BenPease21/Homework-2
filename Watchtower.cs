// Written by Ben Pease
// 2/5/2025


using System;

namespace Watchtower2
{
    internal class WatchTower
    {
        static void Main(string[] args)
        {
            Watchtower tower = new Watchtower();
            tower.Inputxvalue = 5;
            tower.Inputyvalue = -3;
            Console.WriteLine("Output X: " + tower.Outputxvalue + "\nOutput Y: " + tower.Outputyvalue);
            Console.WriteLine("Direction: " + Watchtower.Direction(tower.Outputxvalue, tower.Outputyvalue));
        }
    }

    public class Watchtower
    {
        private int inputxvalue = -1000;
        private int inputyvalue = -1000;

        public int Inputxvalue
        {
            get { return inputxvalue; }
            set { inputxvalue = value; }
        }

        public int Inputyvalue
        {
            get { return inputyvalue; }
            set { inputyvalue = value; }
        }

        public int Outputxvalue
        {
            get
            {
                if (Inputxvalue < 0) return -1;
                if (Inputxvalue == 0) return 0;
                return 1;
            }
        }

        public int Outputyvalue
        {
            get
            {
                if (Inputyvalue < 0) return -1;
                if (Inputyvalue == 0) return 0;
                return 1;
            }
        }

        public static string Direction(int xdirection, int ydirection)
        {
            if (xdirection < 0)
            {
                if (ydirection > 0) return "North West";
                if (ydirection == 0) return "West";
                return "South West";
            }
            else if (xdirection == 0)
            {
                if (ydirection > 0) return "North";
                if (ydirection == 0) return "Here";
                return "South";
            }
            else // xdirection > 0
            {
                if (ydirection > 0) return "North East";
                if (ydirection == 0) return "East";
                return "South East";
            }
        }
    }
}