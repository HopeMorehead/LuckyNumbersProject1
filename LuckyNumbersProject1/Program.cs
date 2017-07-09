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
            int total;
            int count = 0;
            //int Tempval = answer[i];

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
                    if (number2 == number)
                    {
                        count++;
                        break;
                    }

                   
                   

                }
               
                Console.WriteLine("\t\n " + number + " occurs " + count + " times");
                if (number == jackPot)
                {
                    Console.WriteLine("You won the jackpot");
                }

            }
            // Console.WriteLine("You still had a chance to win the jack pot number is 63 and worth 2000 dollars");




            //if (number == jackPot)
            //{
            //    Console.WriteLine("You have won the JackPot");
            //}
            //else
            //{
            //    Console.WriteLine("You have not won the JackPot");
            //}


            total = count * count;
                Console.WriteLine($"Total Points earned:{total}");


                










            
           
        }

    }
}



