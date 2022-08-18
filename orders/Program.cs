using System;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for(int i =1; i <= N; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
           }
           Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
