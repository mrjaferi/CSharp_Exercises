using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            bool continuePlaying = true;
            string userChoice, computerChoice;

            while (continuePlaying)
            {
                userChoice = GetUserChoice();
                computerChoice = GetComputerChoice(random);

                Console.WriteLine($"Player: {userChoice}");
                Console.WriteLine($"Computer: {computerChoice}");

                DetermineWinner(userChoice, computerChoice);

                continuePlaying = ConfirmContinuePlaying();
            }

            Console.WriteLine("Thanks for playing!");
        }

        static bool ConfirmContinuePlaying()
        {
            Console.Write("Would you like to continue playing (Y/N): ");
            var answer = Console.ReadLine();
            return answer.ToUpper() == "Y";
        }

        static string GetUserChoice()
        {
            string userChoice = "";
            while (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();
            }

            return userChoice;
        }

        static string GetComputerChoice(Random random)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    return "";
            }
        }

        static void DetermineWinner(string userChoice, string computerChoice)
        {
            switch (userChoice)
            {
                case "ROCK":
                    if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }
        }
    }
}
