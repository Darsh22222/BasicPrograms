using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class FlipC
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin >= 0)
            {
                for (int i = 1; i <= flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The random Number generated :" + number);

                    if (number == 1)
                    {
                        TailCount++;
                    }
                    else 
                    {
                        HeadCount++; 
                    }
                  
                    
                }
                Console.WriteLine("The Count of Head is : " + HeadCount);
                Console.WriteLine("The Count of Tail is : " + TailCount);

                HeadPercentage = (HeadCount * 100) / flipCoin;
                TailPercentage = (TailCount * 100) / flipCoin;

                Console.WriteLine("Head Percentage : " + HeadPercentage);
                Console.WriteLine("Tail Percentage : " + TailPercentage);
            }

            else
            {
                Console.WriteLine("Please enter the positive number");
            }
        }
    }
}
