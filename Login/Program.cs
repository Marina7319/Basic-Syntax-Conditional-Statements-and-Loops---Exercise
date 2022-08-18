using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int userNameLenght = userName.Length - 1;
            string password = "";
            for (int value = userNameLenght; value >= 0; value--)
            {
                password += userName[value];
            }
            int countOfWrongPasswords = 0;
            string inputPassword = Console.ReadLine();
            while (inputPassword != password)
            {
                countOfWrongPasswords++;
                if (countOfWrongPasswords > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }
            if (inputPassword == password)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
