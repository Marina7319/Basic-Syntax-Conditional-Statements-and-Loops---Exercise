using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double totalNumsOfSaber = Math.Ceiling(studentsCount * 1.10);
            double numberOfFreeBelts = Math.Floor(studentsCount / 6.0);
            double finalPriceForSabers = totalNumsOfSaber * priceOfSaber;
            double finalPriceForRobes = studentsCount * priceOfRobes;
            double finalPriceForBelts = (studentsCount - numberOfFreeBelts) * priceOfBelts;
            double totalFinalPrice = finalPriceForSabers + finalPriceForRobes + finalPriceForBelts;
            if (totalFinalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(budget - totalFinalPrice);
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
