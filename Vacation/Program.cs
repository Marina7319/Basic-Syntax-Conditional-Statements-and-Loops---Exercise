using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 16;
                }
                if (peopleCount >= 100)
                {
                    switch (day)
                    {
                        case "Friday":
                            totalPrice = (peopleCount - 10) * 10.9;
                            break;
                        case "Saturday":
                            totalPrice = (peopleCount - 10) * 15.6;
                            break;
                        case "Sunday":
                            totalPrice = (peopleCount - 10) * 16;
                            break;
                    }
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 22.50;
                }
                if (peopleCount >= 10 && peopleCount < 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            if (peopleCount >= 30 && groupType == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
