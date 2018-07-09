using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PreAndPostFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluating expression ---");
            //var expression = EvaluatePostFix("2 33 * 5 4 * + 9 -");
            var expression = EvaluatePreFix("- + * 2 3 + 5 4 9");
            Console.WriteLine($"Output is {expression}");
            Console.Read();


        }
        static int EvaluatePostFix(string input)
        {
            var expression = input.Split(' ');
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOprand(expression[i]))
                {
                    s.Push(Convert.ToInt16(expression[i]));
                }
                else if (IsOprator(expression[i]))
                {
                    int op2 = s.Pop();
                    int op1 = s.Pop();
                    var result = PerformOperation(expression[i], op1, op2);
                    s.Push(result);
                }
            }
            return s.Pop();
        }

        private static int PerformOperation(string v, int op1, int op2)
        {
            switch (v)
            {
                case "*":
                    return op1 * op2;
                case "+":
                    return op1 + op2;
                case "-":
                    return op1 - op2;
                default:
                    return op1 / op2;
            }
        }

        static int EvaluatePreFix(string input)
        {
            var expression = input.Split(' ');
            Stack<int> s = new Stack<int>();
            for (int i = expression.Length - 1; i >= 0; i--)
            {
                if (IsOprand(expression[i]))
                {
                    s.Push(Convert.ToInt16(expression[i]));
                }
                else if (IsOprator(expression[i]))
                {
                    int op1 = s.Pop();
                    int op2 = s.Pop();
                    var result = PerformOperation(expression[i], op1, op2);
                    s.Push(result);
                }
            }
            return s.Pop();
        }

        private static bool IsOprator(string v)
        {
            var reges = new Regex("^[\\/\\+\\-\\*]$");
            return reges.IsMatch(v);
        }

        private static bool IsOprand(string v)
        {
            var reges = new Regex("^\\d+$");
            return reges.IsMatch(v);
        }
    }
}
