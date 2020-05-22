﻿using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int secretNumber = rand.Next(1, 101);

            int guessesGiven = 0;

            while (guessesGiven < 4)
            {
            Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1})");
            string userGuess = Console.ReadLine();
            int userGuessInt = Int32.Parse(userGuess);

            if (userGuessInt == secretNumber)
            {
                Console.WriteLine("Yup! you guessed right!");
                break;
            }
            else
            {
                Console.WriteLine("Nope, you guessed wrong..");
            }
                guessesGiven++;
            if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("lower!");
                }
            else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("higher!");
                }
            }

        }
    }
}
