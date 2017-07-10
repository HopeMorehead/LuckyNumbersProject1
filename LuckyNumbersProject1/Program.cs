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


            int jackPot = 63;
            int i;
            int a;
        //    int total;
            int count;
            //    int correctGuess;
            bool exit = false;
            int sum;
            //int Tempval = answer[i];
            do
            {
                Console.WriteLine("Pick a low start number.");
                int minValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick a high end number.");
                int maxValue = int.Parse(Console.ReadLine());


                int[] answer = new int[6];
                for (i = 0; i < answer.Length; i++)
                {
                    Console.WriteLine($"Please enter answer 6 numbers");
                    answer[i] = int.Parse(Console.ReadLine());
                    if (answer[i] < minValue || answer[i] > maxValue)
                    {
                        Console.WriteLine($"invalid must be between {minValue} and {maxValue}. Please enter again:");
                        answer[i] = int.Parse(Console.ReadLine());
                    }



                    else
                    {
                        Console.Clear();
                        Console.Write($"{answer[0]},{answer[1]},{answer[2] },{answer[3]},{answer[4]},{answer[5]}");
                       
                    }

                }

                Console.Clear();
                Random random = new Random();
                int[] winnings = new int[6];

                for (a = 0; a < winnings.Length; a++)
                {
                    winnings[a] = random.Next(0, winnings.Length - 1);
                    Console.WriteLine("Lucky Numbers :" + winnings[a]);
                }
                //   bool result;
                foreach (int number in answer)
                {
                    count = 0;
                    foreach (int number2 in winnings)
                    {
                        if (number == number2)
                        {
                            count++;
                            //How many guessed correctly



                         //   Console.WriteLine(number);
                        //    answer.Intersect(winnings).Count();
                             // break;

                        }
                    }
                   

                    Console.WriteLine("\t\n " + number + " occurs " + count + "times");

                    sum = 0 + count++;
                    Console.WriteLine($"Total Points earned:{sum}");

                    if (number == jackPot)
                    {
                        Console.WriteLine("You won the jackpot");

                    }
                   
                }
            } while (exit == false);
        }

    }
}


//Console.WriteLine("You have guessed correctly! It only took you: " + number + " tries.");
//                                    Console.WriteLine("Would you like to play again? (y/n)");
//                                    userChoice = Console.ReadLine();
//                                    if (userChoice == "n")
//                                    {
//                                        Console.WriteLine("Thanks for playing!");
//                                        Environment.Exit(0);
//                                    }
//                                    else if (userChoice == "y")
//                                    {
//                                        over = false;
//                                    }
