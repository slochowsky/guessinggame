using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {

            Random rand = new Random ();

            int secretNumber = rand.Next (1, 101);

            Console.WriteLine ("Select Difficulty: Easy, Medium, Hard, or Cheater");
            string difficulty = Console.ReadLine ();

            int attempts = 0;
            int allowed = 8;

            if (difficulty == "Easy") {
                allowed = 8;
            } else if (difficulty == "Medium") {
                allowed = 6;
            } else if (difficulty == "Hard") {
                allowed = 4;
            } else if (difficulty == "Cheater") {
                allowed = 8;
            } else {
                Console.WriteLine ("Select Difficulty: Easy, Medium, Hard, or Cheater");
                difficulty = Console.ReadLine ();
            }

            if (difficulty == "Cheater") {
                while (true) {
                    Console.WriteLine ($"Guess the secret number. Your guess ({attempts + 1})");
                    string userGuess = Console.ReadLine ();
                    int userGuessInt = Int32.Parse (userGuess);
                    if (userGuessInt == secretNumber) {
                        Console.WriteLine ("Yup! You guessed it!");
                        break;
                    } else if (userGuessInt > secretNumber) {
                        Console.WriteLine ("Nope, too high!");
                    } else if (userGuessInt < secretNumber) {
                        Console.WriteLine ("Nope, too low!");
                    }
                    attempts++;
                }
            } else {
                while (attempts < allowed) {
                    Console.WriteLine ($"Guess the secret number. Your guess ({attempts + 1})");
                    string userGuess = Console.ReadLine ();
                    int userGuessInt = Int32.Parse (userGuess);
                    if (userGuessInt == secretNumber) {
                        Console.WriteLine ("Yup! You guessed it!");
                        break;
                    } else if (userGuessInt > secretNumber) {
                        Console.WriteLine ("Nope, too high!");
                    } else if (userGuessInt < secretNumber) {
                        Console.WriteLine ("Nope, too low!");
                    }
                    attempts++;
                }
            }
        }
    }
}