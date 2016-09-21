using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_new
{
    class Program
    {
        enum Roshambo
        {
            Rock,
            Paper,
            Scissors
        }
        static void Main(string[] args)
        {
            string cont;
            string playerChoice;
            string computerChoice;
            string[] RPS = { "R", "P", "S" };
            Random ranNumberGenerator = new Random();

            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.WriteLine("Enter your name:\n");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {name}! Would you like to play against TheJets or TheSharks?\n");
            string opponent = Console.ReadLine().ToLower();
            Console.WriteLine($"\nYour opponent is {opponent}.\n");

            {
                do
                {

                    Console.WriteLine("");
                    Console.WriteLine("Rock, paper, or scissors? (R/P/S)\n");
                    playerChoice = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    switch (playerChoice)
                    {
                        case "R":
                        case "P":
                        case "S":
                            computerChoice = RPS[ranNumberGenerator.Next(RPS.Length)];              
                            Console.WriteLine($"{opponent}: " + computerChoice);
                            if (computerChoice == playerChoice)
                            {
                                Console.WriteLine($"Draw! Play again, {name}!\n");
                            }
                            else
                            {
                                switch (computerChoice)
                                {
                                    case "R":
                                        if (playerChoice == "P" || playerChoice == "paper")
                                        {

                                            Console.WriteLine($"\n{name} wins!\n");
                                        }
                                        else
                                        {

                                            Console.WriteLine($"\n{opponent} wins!\n");
                                        }
                                        break;

                                    case "P":
                                        if (playerChoice == "R" || playerChoice == "rock")
                                        {

                                            Console.WriteLine($"\n{opponent} wins!\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n{name} wins!\n");
                                        }
                                        break;

                                    case "S":
                                        if (playerChoice == "P" || playerChoice == "paper")
                                        {
                                            Console.WriteLine($"\n{opponent} wins!\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n{name} wins!\n");
                                        }
                                        break;
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }
                    Console.WriteLine("Play again? (y/n)\n");
                    cont = Console.ReadLine();
                } while (cont == "y");
                Console.WriteLine($"Thanks for playing, {name}!\n");

            }
         
        }
    }
}
    

