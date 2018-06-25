using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    //The prime factors of 13195 are 5, 7, 13 and 29.

    //What is the largest prime factor of the number 600851475143 ?
    class Program
    {
        static void Main(string[] args)
        {
            // PrimeFactor(600851475143);//CalculatePrimNumber(10);
            CalculatePrimNumber(1000);
            //Console.WriteLine($"result {result}");
            Console.Read();
        }

        //may way to calculate prime numbers
        /// <summary>
        /// prime numbers are 6n+1 or 6n-1
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        static void CalculatePrimNumber(long input)
        {

            //calculate prime number
            //long[] f = new long[input + 1];
            //f[0] = 1;
            //f[1] = 2;
            //f[2] = 3;
            //for (int i = 0; i < input; i++)
            //{
            //    f[i] = 6 * i - 1;
            //    Console.WriteLine(f[i + 2]);
            //}
            //return f[input];

            //foreach prim number divid and get till when I an getting while numbers
            for (int i = 1; i <= input; i++)
            {
                //if (IsPrimaryNumber(i))
                //    Console.WriteLine($"{i}");
                if (BetterApproach(i))
                    Console.WriteLine($"{i}");
            }

        }
        //better approach to provide prime number O(underoot n)
        static bool BetterApproach(long input)
        {
            if (input < 1) return false;
            if (input < 3) return true;

            if (input % 2 == 0 || input % 3 == 0) return false;

            for (int i = 5; i * i <= input; i += 6)
            {
                if (input % i == 0 || input % (i + 2) == 0)
                    return false;

            }
            return true;
        }

        static bool IsPrimaryNumber(long number)
        {
            if (number < 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        ///find maximum prime fator
        ///
        static void PrimeFactor(long input)
        {
            //divide the input till it is divided 2
            while (input % 2 == 0)
            {
                Console.WriteLine($"2 = ");
                input /= 2;
            }

            // n must be odd here
            // skip 2 and start with 3
            for (int i = 3; i <= Math.Sqrt(input); i += 2)
            {

                while (input % i == 0)
                {
                    Console.WriteLine($" i = {i}");
                    input /= i;
                }
            }

            if (input > 2)
                Console.WriteLine($"input {input}");
        }

        static void PrintPrimeNumbers(long number)
        {
            //As array index started from 0
            number = number + 1;
            //create a bool array
            bool[] primeArray = new bool[number];

            //first assign all the elements to true
            for (int j = 2; j < number; j++)
                primeArray[j] = true;

            //never consider 0 and 1 so marking it as false
            //primeArray[0] = primeArray[1] = false;

            int i = 2;
            while (i < number)
            {
                //break the loop if i*i greater than the given number
                if (i * i >= number)
                {
                    break;
                }

                //iterate the array and mark the array positions to false
                // 4,6,8... mark false
                // 9,12,15,18 .. mark as false and continue
                for (int j = i * i; j < number; j += i)
                {
                    if (j % i == 0)
                    {
                        primeArray[j] = false;
                    }
                }

                //loop variable i increment
                for (int j = i + 1; j < number; j++)
                {
                    if (primeArray[j] == true)
                    {
                        i = j;
                        break;
                    }
                }
            }

            //print all the numbers
            for (int j = 2; j < number; j++)
            {
                if (primeArray[j])
                    Console.WriteLine(j);
            }

        }


    }
}
