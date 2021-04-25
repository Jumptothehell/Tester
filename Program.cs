using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int PascalRank = int.Parse(Console.ReadLine());
            Triangle(InvalidRank(PascalRank));
        }
        static void Triangle(int Rank)
        {
            int val = 1;
            for (int i = 0; i <= Rank; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
        static int InvalidRank(int Rank)
        {
            while (Rank < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                Rank = int.Parse(Console.ReadLine());
            }
            return Rank;
        }
    }
}
