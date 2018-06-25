using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabseCall _db = new DatabseCall();
            _db.GetEmployeeById(11);
            //A _a = new B();
            ////  B _a = new A();
            //_a.NewMethod();

            //B _b = new B();
            //_b.NewMethod(1);
            //Console.WriteLine(Convert.ToString(_b));
            //if (typeof(A) is object)
            //{
            //    Console.WriteLine("True");
            //}
            A objA = new A();
            objA.method();

            B objB = new B();
            objB.method();


            C objC = new C();
            objC.method();
            Console.ReadKey();
        }
    }

    //class A
    //{
    //    public virtual void PrintShow()
    //    {
    //        Console.WriteLine("A.");
    //    }

    //    public void NewMethod()
    //    {
    //        Console.WriteLine("A.NewMethd");
    //    }
    //}
    //class B : A
    //{
    //    public override void PrintShow()
    //    {
    //        Console.WriteLine("B.Show()");
    //    }
    //    public void NewMethod(int i)
    //    {
    //        Console.WriteLine("B.NewMethd");
    //    }


    //}
    class A
    {
        public int a1 { get; set; }
        public int a2 { get; set; }
        protected int a3 { get; set; }
        public virtual void method()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        
        public override void method()
        {
            Console.WriteLine($"B {a3}");
        }
    }
    class C : B
    {
        public new void method()
        {
            Console.WriteLine("C");
        }
    }
}
