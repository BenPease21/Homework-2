using System.Runtime.InteropServices;

namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main()
        {
            int[] scores = new int[5];

            for (int i = 0; i < 5; i=i+1)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                scores[i] = a;
            }

            int[] scores2 = new int[5];

            for (int i = 0; i < 5; i = i + 1)
            {
                scores2[i] = scores[i];
            }

            Console.Write("\nOriginal List: ");
            for (int i = 0; i < 5; i=i + 1)
            {
                Console.Write(scores[i]);
            }

            Console.Write("\nDuplicated List: ");
            for (int i = 0; i < 5; i = i + 1)
            {
                Console.Write(scores2[i]);
            }
            Console.WriteLine();

        }
    }
}
