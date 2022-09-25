using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            int playerScore = 0;
            int computerScore = 0;
            bool newGame = true;
            

            while (newGame)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = scissors;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again ...");
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";
                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = rock;
                        break;
                    case 2:
                        computerMove = paper;
                        break;
                    case 3:
                        computerMove = scissors;
                        break;
                }

                Console.WriteLine($"The computer chose {computerMove}.");
                if (playerMove == rock && computerMove == scissors ||
                    playerMove == paper && computerMove == rock ||
                    playerMove == scissors && computerMove == paper)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    playerScore++;
                }
                else if (playerMove == scissors && computerMove == rock ||
                   playerMove == rock && computerMove == paper ||
                   playerMove == paper && computerMove == scissors)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    computerScore++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("This game was a draw.");
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[n]ew game or [q]uit.");
                string newGameCoice = Console.ReadLine();
                if (newGameCoice == "q" || newGameCoice == "quit")
                {
                    newGame = false;
                }
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Final score is: Player -> {playerScore} | Computer -> {computerScore}");

          


        }
    }
}
