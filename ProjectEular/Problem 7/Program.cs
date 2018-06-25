using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        static Dictionary<int, long> _storage = new Dictionary<int, long>();
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?
        static int count = 0;
        static void Main(string[] args)
        {
            for (int i = 2; i < 1000002; i++)
            {
                Console.WriteLine(isPrimeNumber(i));
            }
            Console.ReadKey();
        }

        static bool isPrimeNumber(long n)
        {
            if (n < 1) return false;
            if (n <= 3)
            {
                count++;
                _storage.Add(count, n);
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            count++;
            _storage.Add(count, n);
            return true;
        }
    }
}
