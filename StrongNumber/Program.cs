using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;
            while (number > 0)
            {
                int factorielNumber = 1;
                int currNumber = number % 10;
                number /= 10;
                for (int i = 2; i <= currNumber; i++)
                {
                    factorielNumber *= i;
                }
                sum += factorielNumber;
            }
            Console.WriteLine(sum == numberCopy ? "yes" : "no");
        }
    }
}
