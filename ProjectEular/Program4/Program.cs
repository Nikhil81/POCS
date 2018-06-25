using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //Find the largest palindrome made from the product of two 3-digit numbers.
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr = new string[] { "0","9", "0", "0", "9","0" };
            //  int[] arr = 99990999.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            //var reverse = //isPalindromeNumers(9990999);//isPalindrome(arr, 0, arr.Length - 1);
            //if (reverse.Equals(arr))
            //{
            //if (reverse)
            //    Console.WriteLine("is palindone");
            //else
            //    Console.WriteLine("not palindrome");
            maximumPalindrom();

            //}
            //else
            //    Console.WriteLine("not palindrome");

            Console.Read();
        }

        //splution 1 get reverse of the number and check reverse with original if both are same then palindrome
        static bool isPalindrome(string[] arr, int start, int end)
        {
            while (start < end)
            {

                if (arr[start] != arr[end])
                    return false;
                start++;
                end--;
            }

            return true;
        }
        static bool isPalindrome(int[] arr, int start, int end)
        {
            while (start < end)
            {

                if (arr[start] != arr[end])
                    return false;
                start++;
                end--;
            }

            return true;
        }

        //Solution from best 
        static bool isPalindromeNumers(long input)
        {
            long reversed = 0, n = input;

            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }

            return input == reversed; ;
        }

        static void ProjectEularsEmplementaion()
        {

            long largestNumber = 0, b = 0, db = 0, a = 999;
            while (a >= 100)
            {
                if (a % 11 == 0)
                {
                    b = 999;
                    db = 1;
                }
                else
                {
                    b = 990;
                    db = 11;
                }
                while (b >= a)
                {
                    if (a * b <= largestNumber)
                    {
                        break;
                    }

                    if (isPalindromeNumers(a * b))
                    {
                        largestNumber = a * b;
                    }
                    b = b - db;
                }
                a = a - 1;
            }


        }

        /// <summary>
        /// P=11(9091x+910y+100z)
        /// largestPalindrome = 0
        //a = 999
        //while a >= 100
        //if a mod 11 = 0
        //b = 999
        //db = 1
        //else
        //b = 990 //The largest number less than or equal 999
        //and divisible by 11
        //db = 11
        //while b >= a
        //if a* b <= largestPalindrome
        //break
        //if isPalindrome(a* b)
        //largestPalindrome = a* b
        //b = b-db
        //a = a - 1
        //output largestPalindrome
        /// </summary>
        static void maximumPalindrom()
        {
            List<long> listNumner = new List<long>();
            for (int i = 100; i < 999; i++)
            {
                for (int j = 999; j >= 100; j--)
                {
                    var result = i * j;
                    if (isPalindromeNumers(result))
                    {
                        listNumner.Add(result);
                    }
                }

            }

            var largestPalidronnumber = Max(listNumner);
            Console.WriteLine(largestPalidronnumber);
        }

        static long Max(List<long> source)
        {
            long value = 0;
            bool hasValue = false;
            foreach (var number in source)
            {
                if (hasValue)
                {
                    if (number > value)
                    {
                        value = number;
                    }
                }
                else
                {
                    value = number;
                    hasValue = true;
                }

            }
            if (hasValue)
            {
                return value;
            }

            return 0;
        }

    }
}
