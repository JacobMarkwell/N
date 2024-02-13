using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of N:");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("N must be a positive integer.");
            return;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i == 0 || i == N - 1 || j == 0 || j == N - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
