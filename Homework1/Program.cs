using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            int userGuess = 0;

            Console.WriteLine("Please guess a number between 1 and 100.");

            while (userGuess != number)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < number)
                {
                    Console.WriteLine("Your number is too small, try again");
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("Your number is too big, try again");
                }
            }

            Console.WriteLine($"Congratulations, you guessed the number: {number}");
            Console.ReadLine();
        }
    }
}
