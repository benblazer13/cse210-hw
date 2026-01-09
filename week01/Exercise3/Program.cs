using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes"){

            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            

            int guess = -5329;
            int guessCount = 0;

            while(guess!= magicNumber){
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The number was {magicNumber}!");
                    Console.WriteLine($"It took you {guessCount} guesses!");
                }
            }

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}