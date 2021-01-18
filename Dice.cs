using System;
using System.Collections.Generic;
using System.Text;

namespace RollTheDice
{
    class Dice : IDice
    {

        public int attemptsPlayer1 { get; set; }
        public int attemptsPlayer2 { get; set; }
        public void DicePlayer1()
        {
            Random numberGen = new Random();

            int roll = 0;
            int attempts = attemptsPlayer1;

            Console.WriteLine("Press Enter to roll the dice.");

            while (roll != 6)
            {

                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                Console.WriteLine($"You rolled: {roll}");
                attempts++;
            }
            if (attempts >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (attempts < 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine("Your attempts are: " + attempts + " to roll 6!");
            Console.ForegroundColor = ConsoleColor.Gray;

            attempts = attemptsPlayer1;
        }

        public void DicePlayer2()
        {
            Random numberGen = new Random();

            int roll = 0;
            int attempts = attemptsPlayer2;

            Console.WriteLine("Press Enter to roll the dice.");

            while (roll != 6)
            {

                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                Console.WriteLine($"You rolled: {roll}");
                attempts++;
            }
            if (attempts >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (attempts < 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.WriteLine("Your attempts are: " + attempts + " to roll 6!");
            Console.ForegroundColor = ConsoleColor.Gray;

            attempts = attemptsPlayer2;
        }

        public void Greeting()
        {
            Console.Title = "Dice game";

            Console.WriteLine("Welcome to the game of the dice!");
        }

        public void AskForPlayer2()
        {
            Console.WriteLine("Do you want player 2?");
        }

        public void Player2()
        {
            string player2 = Console.ReadLine();
            if (player2 == "yes")
            {
                DicePlayer2();
            }
            else
            {
                Console.WriteLine("OK, bye!");
            }
        }

        public void Winner()
        {
            if (attemptsPlayer1 > attemptsPlayer2)
            {
                Console.WriteLine("Player 1 is winner!");
            }
            else if (attemptsPlayer1 < attemptsPlayer2)
            {
                Console.WriteLine("Player 2 is winner!");
            }
            else if (attemptsPlayer1 == attemptsPlayer2)
            {
                Console.WriteLine("This is happening so rare! Tie!");
            }
        }

        public Dice()
        {
            Greeting();
            DicePlayer1();
            AskForPlayer2();
            Player2();
            Winner();
        }

    }
}
