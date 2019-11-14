using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_machine_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int productPrice = 20;
            while (true)
            {
                Console.Write("Insert coins (5, 10, 25) >>> ");
                int sumOfCoins = int.Parse(Console.ReadLine());
                while(sumOfCoins < productPrice)
                {
                    Console.Write(sumOfCoins + ": Insert more coins (5, 10, 25) >>> ");
                    sumOfCoins += int.Parse(Console.ReadLine());
                }

                dispenseProduct();
                int change = calculateChange(sumOfCoins, productPrice);
                refundCoins(change);
            }
        }

        private static void dispenseProduct()
        {
            Console.WriteLine("Dispensing Product....");
        }

        private static int calculateChange(int sumOfCoins, int productPrice)
        {
            int change = sumOfCoins - productPrice;
            return change;
        }

        private static void refundCoins(int change)
        {
            if(change <= 0)
            {
                return;
            }

            int quarters = 0;
            int dimes = 0;
            int nickles = 0;

            while (change > 0) {
                if (change >= 25)
                {
                    change -= 25;
                    ++quarters;
                } else if(change >= 10)
                {
                    change -= 10;
                    ++dimes;
                } else if(change >= 5)
                {
                    change -= 5;
                    ++nickles;
                }
            }

            Console.Write("Refunding: ");
            if (quarters > 0)
            {
                Console.Write("[" + quarters + "] Quarters ");
            }

            if (dimes > 0)
            {
                Console.Write("[" + dimes + "] Dimes ");
            }

            if (nickles > 0)
            {
                Console.Write("[" + nickles + "] Nickles ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
