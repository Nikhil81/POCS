using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // CastAndOfType();
            // CastAndOfType();
            // Console.WriteLine(Reverse2("ABCDEFGH"));
            string[] arr = { "A", "B", "C", "D", "E", "F", "G", "H" };
            rvereseArray(ref arr, 0, 7);
            Console.WriteLine("output");

            Console.Read();
        }

        private static void CastAndOfType()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add("2");
            arr.Add(3);
            arr.Add("4");
            arr.Add(5);
            arr.Add("as");

            var casted = arr.OfType<int>();
            foreach (var item in casted)
            {

                Console.WriteLine($"reault is {item}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// My solution 1
        /// complexity O(n)
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private static string Reverse(string source)
        {
            char[] result = new char[source.Length + 1];
            var charArr = source.ToCharArray();
            int j = 0;
            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                result[j] = charArr[i];
                j++;
            }
            return new string(result);
        }

        /// <summary>
        /// Solution 2 need to optimized for odd and even string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private static string Reverse2(string source)
        {
            var charArr = source.ToCharArray();
            int j = 0;
            for (int i = charArr.Length - 1; i >= ((charArr.Length - 1) / 2 - 1); i--)
            {
                char temp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = temp;
                j++;
            }
            return new string(charArr);
        }

        /// <summary>
        /// GreekOfGreek Example
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>

        private static void rvereseArray1(string arr1, int start, int end)
        {
            var arr = arr1.ToCharArray();
            char temp = '1';
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;

                //temp = arr[start];
                //arr[start] = arr[end];
                //arr[end] = temp;
                //start++;
                //end--;

            }
            //return arr;
        }
        private static string[] rvereseArray(ref string[] arr, int start, int end)
        {
            string temp = "";
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }

        
    }
}
