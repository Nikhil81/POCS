using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOfStringusingStgack
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverse = betterApproach("Hello");
            Console.WriteLine(reverse);
            Console.Read();
        }
        static string ReversofString(string reverse)
        {
            var charetersofString = reverse.ToCharArray();
            var reverseofString = new char[charetersofString.Length];
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < charetersofString.Length; i++)
            {
                s.Push(charetersofString[i]);
            }

            for (int i = 0; i < charetersofString.Length; i++)
            {
                reverseofString[i] = s.Pop();
            }
            return new string(reverseofString);
        }

        //better approacj
        static string betterApproach(string n)
        {
            var input = n.ToCharArray();
            int i = 0, j = n.Length - 1;
            while (i < j)
            {
                var temp = input[i];
                input[i] = input[j];
                input[j] = temp;
                i++;
                j--;
            }
            return new string(input);

        }
    }
}
