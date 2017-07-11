using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbersProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating global variables to use in and outside of loops
            int jackPot = 63;
            int i;
            int a;
            int count;
            bool exit = false;
            // Created totalPoints as a
            //Global variable. It's use isn't recognized due to
            //scope
            int totalPoints = 0;
            int money;
            string userChoice;
            do
            {
                Console.WriteLine(" Welcome to the lottery game. Pick a low start number.");
                int minValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick a high end number.");
                int maxValue = int.Parse(Console.ReadLine());




                // creating looped Array for userInput (guessed numbers
                int[] answer = new int[6];
                for (i = 0; i < answer.Length; i++)
                {
                    Console.WriteLine($"Guess six numbers that you think are the LUCKY numbers!");
                    answer[i] = int.Parse(Console.ReadLine());
                    if (answer[i] < minValue || answer[i] > maxValue)
                    {
                        Console.WriteLine($"invalid must be between {minValue} and {maxValue}. Please enter again:");
                        answer[i] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write($"{answer[0]},{answer[1]},{answer[2]},{answer[3]},{answer[4]},{answer[5]}");
                        Console.WriteLine(" Good pick, hope you win!");
                    }
                }



                Console.Clear();



                //Creating Random Generated numbers (lottery
                Random random = new Random();
                int[] winnings = new int[6];
                for (a = 0; a < winnings.Length; a++)
                {
                  //  winnings[a] = random.Next(minValue, maxValue);
                     winnings[a] = random.Next(minValue, maxValue);
                    Console.WriteLine("Lucky Numbers :" + winnings[a]);
                }
                //Looping through both user and random numbers. Nested loop created in an attempt to find numbers
                //of equal value and calculated the number of occurances.
                count = 0;
                foreach (int number in answer)
                {
                    count = 0;
                    foreach (int number2 in winnings)
                    {
                        if (number == number2)
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine("\t\nYou guessed correctly!" + count + " time(s)");

                // An attempt to capture the sum of  duplicates between the userinput and Random
                // and output total to the console.

                //Looping through the userinput and the jackpot number to find matches!

                for (int b = 0; b < answer.Length; b++)
                    foreach (int variable in answer)

                    {
                        if (variable == jackPot)
                        {
                            //   totalPoints = 10 + count;
                            totalPoints = 10;
                            money = 10000;

                        }
                    }
                if (totalPoints == 10)
                {
                    Console.WriteLine($"you won the jackpot amount of {10000}");

                }
                totalPoints = totalPoints + count;
                Console.WriteLine($"Total Points earned:{totalPoints}");


                //Another attempt to capture correct matches between user input and random numbers.

                 if (totalPoints == 0)
                {
                    money = 0;
                    Console.WriteLine($"You won {money} dollars");
                }

                else if (totalPoints == 1)
                {
                    money = 1000;
                    Console.WriteLine($"You won {money} dollars");
                }
                else if (totalPoints == 2)
                {
                   
                    money = 2000;
                    Console.WriteLine($"You won {money} dollars");


                }
                else if (totalPoints == 3)
                {
                   
                    money = 3000;
                    Console.WriteLine($"You won {money} dollars");

                }
                else if (totalPoints == 4)
                {
                    money = 4000;
                    Console.WriteLine($"You won {money} dollars");

                }
                else if (totalPoints == 5)
                {
                    money = 5000;
                    Console.WriteLine($"You won {money} dollars");

                }
                else if (totalPoints == 6)
                {
                    money = 6000;
                    Console.WriteLine($"You won {money} dollars");

                }


                Console.WriteLine("Would you like to play again (y/n)");

                userChoice = Console.ReadLine().ToLower();
                if (userChoice == "n")
                {
                    Console.WriteLine("\"Thanks for playing!\"");
                    Environment.Exit(0);
                }
                else if (userChoice.ToLower() == "y")
                {
                    exit = false;
                }
            } while (exit == false);

        }

    }
}

