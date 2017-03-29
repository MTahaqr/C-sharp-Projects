using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        class Engine
        {
            public string Quality = "A-1";
            public void print()
            {
                Console.WriteLine(Quality);
            }
        }
        class Car
        {
            public string name = "Reborn Modified";
            public string model = "2017";
            public void print()
            {
                Console.WriteLine(name +" "+model +" "+engineObj.Quality );
            }
            Engine engineObj = new Engine(); 

        }
        static void Main(string[] args)
        {
           // Car carObj = new Car();
           // carObj.print();
            
            Console.ReadKey();

        }
    }
}
