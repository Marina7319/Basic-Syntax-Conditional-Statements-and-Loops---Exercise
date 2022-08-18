using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int headSet = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headSet++;
                    if (i % 3 == 0)
                    {
                        keyboard++;
                        if (keyboard % 2 == 0)
                        {
                            display++;
                        }
                    }
                }
                if (i % 3 == 0)
                {
                    mouse++;
                }
            }
            float sum = headSet * headsetPrice + mouse * mousePrice + keyboard * keyboardPrice + display * displayPrice;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
