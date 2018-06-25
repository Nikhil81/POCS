using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, 
    //we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.
    class Program
    {
        static void Main(string[] args)
        {
            var result = CalculateSum(1000);
            Console.WriteLine(result);

            var projectelsuar = SumDivisbleBy(3, 999) + SumDivisbleBy(5, 999) - SumDivisbleBy(15, 999);
            Console.WriteLine(projectelsuar);
            Console.Read();

        }

        //My solution
        private static decimal CalculateSum(int maximumNumber)
        {
            decimal result = 0;
            if (maximumNumber <= 0)
            {
                return 0;
            }
            for (int i = 1; i <= maximumNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {

                    result += i;
                }
            }
            return result;
        }

        //Project Eular solution
        /// <summary>
        /// Function SumDivisibleBy(n)
        //p=target div n
        ///return n*(p*(p+1)) div 2
        ///EndFunction
        //Output SumDivisibleBy(3)+SumDivisibleBy(5)-SumDivisibleBy(15)
        /// </summary>
        /// P - number
        /// n - dicided by
        /// n*N*(N+1)/2.
        /// n*(p/n)*((p/n)+1)/2
        /// <returns></returns>
        private static long SumDivisbleBy(int n, int p)
        {
            return n * (p / n) * ((p / n) + 1) / 2;
        }
    }
}
