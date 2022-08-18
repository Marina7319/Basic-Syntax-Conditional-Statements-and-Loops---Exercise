using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                i++;
                int j = 0;
                while (j < i)
                {
                    j++;
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
