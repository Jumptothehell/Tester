using System;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int PascalRank = int.Parse(Console.ReadLine());
            Triangle(PascalRank);
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
    }
}
