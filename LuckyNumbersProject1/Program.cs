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
            int jackPotAmount = 60000;
            int i;
            int a;
            int count;
            bool exit = false;
            int sum;
            // Created totalPoints as a
            //Global variable. It's use isn't recognized due to
            //scope
            int totalPoints;
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
                    winnings[a] = random.Next(minValue, maxValue);
                 // winnings[a] = random.Next(0, winnings.Length - 1);
                    Console.WriteLine("Lucky Numbers :" + winnings[a]);
                }
                //Looping through both user and random numbers. Nested loop created in an attempt to find numbers
                //of equal value and calculated the number of occurances.

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
                    Console.WriteLine("\t\nYou guessed " + number + "  that number is a lucky Number " + count + " time");

                    // An attempt to capture the sum of  duplicates between the userinput and Random
                    // and output total to the console.
                    sum = 0 + count++;
                    Console.WriteLine($"Total Points earned:{sum}");


                    Console.WriteLine("The JackPot number is 63!");
                    if (number == jackPot)
                    {
                        money = jackPotAmount;
                        Console.WriteLine($"63 isn't a lucky number but it is the jackpot number. You won the jackpot of {money}!");

                    }
                    else
                    {
                        Console.WriteLine("You didn't win the jackpot");
                    }




                    //Another attempt to capture correct matches between user input and random numbers.

                    if (count++ ==0)
                    {
                        totalPoints =0;
                        money = 1000 + jackPotAmount;
                        Console.WriteLine("You won 0 dollars");
                    }

                    else if (count++ == 1)
                    {
                        totalPoints = 10;
                        money = 1000+jackPotAmount;
                        Console.WriteLine("You won 1000 dollars");
                    }
                    else if (count++ == 2)
                    {
                        totalPoints = 20;
                        money = 2000;
                        Console.WriteLine("You won 2000 dollars");


                    }
                    else if (count++ == 3)
                    {
                        totalPoints = 30;
                        money = 3000;
                        Console.WriteLine("You won 3000 dollars");

                    }
                    else if (count++ == 4)
                    {
                        totalPoints = 40;
                        money = 4000;
                        Console.WriteLine("You won 4000 dollars");

                    }
                    else if (count++ == 5)
                    {
                        totalPoints = 50;
                        money = 5000;
                        Console.WriteLine("You won 5000 dollars");

                    }
                    else if (count++ == 6)
                    {
                        totalPoints = 60;
                        money = 6000;
                        Console.WriteLine("You won 6000 dollars");

                    }
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

