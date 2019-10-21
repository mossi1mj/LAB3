using System;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            string name, answer;
            bool continueApp = true;

            Console.WriteLine("Hello, what is your name? ");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine($"Okay {name}, let's get started.\nEnter a number between 1 and 100:");
                number = double.Parse(Console.ReadLine());

                if (number <= 25)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{name}, {number} is even and less than 25");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, {number} is odd and less than 25");
                    }
                }
                else if (number >= 26 && number <= 59)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{name}, {number} is even.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, {number} is odd.");
                    }
                }
                else if (number >= 60 && number <= 100)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{name}, {number} is even.");
                    }
                    else
                    {
                        Console.WriteLine($"{name}, {number} is odd.");
                    }
                }
                else
                {
                    Console.WriteLine($"{name}, {number} was outside of the range.\nThe number needs to be between 1 and 100:");
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                answer = Console.ReadLine().ToLower();
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine($"You have enetered {answer}\nPlease enter either (y/n)");
                    answer = Console.ReadLine().ToLower();
                }
                if (answer == "n")
                {
                    Console.WriteLine("Good Bye");
                    continueApp = false;
                }
            }
            while (continueApp);
        }
    }
}
