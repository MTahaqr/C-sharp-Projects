using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @base
{
    class Program
    {
        class parent
        {
            public parent()
            {
                Console.WriteLine("parent constructor");
            }
            public parent(int x, int y)
                {
                Console.WriteLine("parent constructor" + x + y);
                }
            public parent(double x, double y)
            {
                Console.WriteLine("parent constructor" + x + y);
            }
            public void print()
            {
                Console.WriteLine("I m in parent class print method");

            }
        }
        class child:parent
        {
            public child():base(2.1,4.5)
            {
                Console.WriteLine("Child Constructor");
            }
            public void print1()
            {
                base.print();
                Console.WriteLine("I m in child class print method");
                base.print();

            }
        }
        static void Main(string[] args)
        {
            child obj = new child();
            obj.print1();
            Console.ReadKey();
        }
    }
}
