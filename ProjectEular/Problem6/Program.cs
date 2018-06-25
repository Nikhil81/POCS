using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        //Sum square difference
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumberDiffrence());
            Console.Read();
        }
        static long GetNumberDiffrence()
        {
            long num = 100;

            //sum of 1*1 +2*2 ..100*100
            long sumofSquarofNaturalNumber = (num * (num + 1) * (num * 2 + 1)) / 6;

            //sum o fnatural number and sqar
            long sumOfNaturalNumebrandSqar = (num * (num + 1)) / 2;

            return sumOfNaturalNumebrandSqar * sumOfNaturalNumebrandSqar - sumofSquarofNaturalNumber;
        }
    }
}
