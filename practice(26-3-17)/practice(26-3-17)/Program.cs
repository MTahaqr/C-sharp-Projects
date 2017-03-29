using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_26_3_17_
{
    class Program
    {
        class defaultConstructor
        {
            private int a;
            private int b;
            private string privateVariable;
            public string _privateVariable
            {
                set { privateVariable = value; }
                get { return privateVariable; }
            }
            public void print()
            {
                Console.WriteLine("privateVariable " + _privateVariable);
                Console.WriteLine("\n=================================================");
            }
            //Default constructor
            public defaultConstructor()
            {
                a = 100;
                b = 200;
                Console.WriteLine(" n0nParaConstructor " + a +" " + b);
                
                
            }

        }
        //====================================================================
        class paraConstructor
        {
            private int a;
            private int b;

            public paraConstructor(int first, int second)
                {
                a = first;
                b = second;
                Console.WriteLine(" paraConstructor " + a + " " + b);
                Console.WriteLine("\n=================================================");
            }

        }
        //====================================================================
        class copyConstrucor
        {
            private string name;
            private int age;
            public copyConstrucor(string naam,int umar) //paraConstructor
            {
                name = naam;
                age = umar;
                Console.WriteLine(" Copy Constructor:");
                Console.WriteLine("In paraConstructor");
                Console.WriteLine("name = " + name + " age = "+age);
            }
            public copyConstrucor(copyConstrucor obj) //paraConstructor
            {
                name = obj.name;
                age = obj.age;
                Console.WriteLine("In CopyConstructor");
                Console.WriteLine("name = " + name + " age = " + age);
                Console.WriteLine("\n=================================================");
            }

        }
        //====================================================================
        static void Main(string[] args)
        {
            defaultConstructor obj = new defaultConstructor();
            obj._privateVariable = " This variabe is private";
            obj.print();
            //====================================================================
            paraConstructor firstObj = new paraConstructor(1, 1);
            paraConstructor secondObj = new paraConstructor(2, 2);
            //====================================================================
            copyConstrucor obj1 = new copyConstrucor("Taha",20);
            copyConstrucor obj2 = new copyConstrucor(obj1);

            //====================================================================
            Console.ReadLine();
                
        }
    }
}
