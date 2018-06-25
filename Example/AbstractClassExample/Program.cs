using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    abstract class AbstractClass
    {
        static AbstractClass()
        { }
       public abstract void NewMethod();

    }

    class Child : AbstractClass
    {
        public override void NewMethod()
        {
            throw new NotImplementedException();
        }
    }

    class NormalbaseClass
    {
        protected virtual void GetVirtualImplementaion()
        { }
    }

    class ChildNormal : NormalbaseClass
    {
        protected override void GetVirtualImplementaion()
        { }

    }
}
