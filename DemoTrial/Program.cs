using System;

namespace DemoTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            String winWord = "Money";
            String guessWord = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Chances Left: " + (guessLimit - guessCount));
                    Console.Write("Enter a word : ");
                    guessWord = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuess = true;
                }
            } while (winWord != guessWord && !outOfGuess);
            if (outOfGuess) {
                Console.WriteLine("You Lose ! No chance Left");
            }
            else
            {
                Console.WriteLine("You Win ! Congrats");
            }
        }
    }
}

//OOPS concepts
// .net framework

