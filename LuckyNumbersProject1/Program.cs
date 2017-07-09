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
                int count = 0;
                foreach (int number2 in winnings)
                {
                    if (number2 == number)
                    {
                        count = count + 1;

                        Console.WriteLine("\t\n " + number + " occurs " + count + " times");
                    }
                }
                //    Console.WriteLine(number == number2);
                // result = true;
                //  Console.WriteLine("number{0}",number==number2);

            }
            
        }

    }
}



//    Console.WriteLine("\t\n " + answer + " occurs " + count + " times");
//}
//   Console.WriteLine(Array.IndexOf(answer, “October”));

