using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nameRef ="a";
            //string nameOut = "O";
            //RefandOut _refAndOut = new RefandOut();
            //_refAndOut.RefExample(ref nameRef);
            //_refAndOut.OutExample(out nameOut);

            child c = new child();
            c.Test(5.0d);
            Console.Read();
        }

    }
    class RefandOut
    {
        public void RefExample(ref string name)
        {
            Console.WriteLine($"ref out put {name}");
        }

        public void OutExample(out string name)
        {
            name = "OutExample";
            Console.WriteLine($" out put is {name}");
        }


    }

    abstract class NewUnNamedClass
    {
        public void NewMethod()
        {

            Console.WriteLine("called");
        }

        public virtual void Method()
        {
        }
    }
    class childClass : NewUnNamedClass
    {
        
        public void ChildClass()
        {
            Console.WriteLine("new funcion");
        }
        public override void Method()
        {
        }
    }


    interface IInertface
    {
    }

    class Parent
    {
        public void Test(double a)
        {
            Console.WriteLine("a");
        }
    }

    class child : Parent
    {
        public void Test(int b)
        {
            Console.WriteLine(" b");
        }

    }
     


}
