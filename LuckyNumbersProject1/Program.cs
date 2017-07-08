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

            Console.WriteLine("Pick a low start number.");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick a high end number.");
            int maxValue = int.Parse(Console.ReadLine());

            int[] answer = new int[6];

            for (int i = 0; i < answer.Length; i++)
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
                    Console.WriteLine($"{answer[0]},{answer[1]},{answer[2] },{answer[3]},{answer[4]},{answer[5]}");


                }
            }

                Random random = new Random();
                int[] winnings = new int[6];
                for (int a = 0; a < winnings.Length; a++)
                {
                    winnings[a] = random.Next(0, winnings.Length - 1);
                    Console.WriteLine("Lucky Numbers :" + winnings[a]);
                }

            foreach (var numberA in answer)
            {
                foreach (var numberB in winnings)
                {
                    if (numberA != numberB)
                    {
                        Console.WriteLine("You won");
                    }
                }
            }





            /* if(answer[i] == winnings[a])
         {
             Console.WriteLine("Ya");
         }*/

            /*  Random random = new Random();
            int[] winnings = new int[6];
            for (int i = 0; i < winnings.Length; i++)
            {
                winnings[i] = random.Next(0, winnings.Length - 1);
                Console.WriteLine("Lucky Numbers :" winnings[i]);*/
            //   }


        }


    }
}
/*Lucky Number: 12
Lucky Number: 47
Lucky Number: 28
Lucky Number: 3
Lucky Number: 19
Lucky Number: */
