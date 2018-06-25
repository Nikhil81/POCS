using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        static void Main(string[] args)
        {
            //long number = 3000;
            //bool found = false;
            //List<bool> _found = new List<bool>();
            //while (number >= 3000)
            //{
            //    int i = 2;
            //    while (i <= 20)
            //    {

            //        if (number % i == 0)
            //        {
            //            found = true;
            //            _found.Add(true);



            //        }
            //        else
            //        {
            //            _found.Add(false);
            //            found = false;
            //        }

            //        i++;
            //    }
            //    if (!_found.Any(x => x == false))
            //    {
            //        Console.WriteLine(number);
            //        break;
            //    }
            //    _found.Clear();
            //    number++;
            //}
            // GetNumeorator();
            long res = 1;
            for (long i = 2; i <= 20; i++)
            {
                res = lcm(res, i);
            }

            //printf("%d\n", res);
           // return 0;

            Console.Read();

        }



        static long gcd(long a, long b)
        {
            while (b != 0)
            {
                a %= b;
                a ^= b;
                b ^= a;
                a ^= b;
            }

            return a;
        }

      static  long lcm(long a, long b)
        {
            return a / gcd(a, b) * b;
        }
        //solution 2


    }
}
