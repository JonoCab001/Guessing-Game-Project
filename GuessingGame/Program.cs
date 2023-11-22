using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumb = rnd.Next(1, 100);
            int guessAttempts;
            int guessAttemptsCount = 0;

            Console.Write("Enter a number between 1 to 100: ");
            guessAttempts = int.Parse(Console.ReadLine());

            while (guessAttempts != randomNumb)
            {

                if (guessAttempts > randomNumb)
                {
                    Console.WriteLine("Too High, try again :(");
                    Console.Write("Enter a number between 1 to 100: ");
                    guessAttempts = int.Parse(Console.ReadLine());
                    guessAttemptsCount++;
                }

                if (guessAttempts < randomNumb)
                {
                    Console.WriteLine("Too Low, try again :(");
                    Console.Write("Enter a number between 1 to 100: ");
                    guessAttempts = int.Parse(Console.ReadLine());
                    guessAttemptsCount++;
                }

                guessAttemptsCount++;

            }
            Console.WriteLine("Correct! Good job! :)\n\nYou've took {0} guesses\n\nThank you for playing my game! :)", guessAttemptsCount);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}