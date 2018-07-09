using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            SomeMethod(out i);
            SomeMethod1(ref i);

        }
        static void SomeMethod(out string value)
        {
            value = "";
        }
        static void SomeMethod1(ref string value)
        {
        }
    }
}
