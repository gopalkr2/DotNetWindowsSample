using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helloworld
{
    class Program
    {
	//Testing
        static void Main(string[] args)
        {
            Console.WriteLine("Lets check prime numbers, enter a number");
            string num = Console.ReadLine();
            int prime = 2;

            if (int.TryParse(num, out prime))
            {
                Console.WriteLine("Sorry Error, try again");
            }
            else
            {
                if (IsPrime(prime))
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {

                    Console.WriteLine("The number is not prime");
                }
            }
            Console.ReadKey();

            //end of program
        }

        private static bool IsPrime(int number)
        {
            int notUsed = 8;
            //check for evenness
            if (number % 2 == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                return false;
            }
            //don't need to check past the square root
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return true;
            //while (true) { ;}


            //repeat, Am I crazy ?
            //for (int i = 3; i <= max; i += 2)
            //{
            //    if ((number % i) == 0)
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }

    }
}
