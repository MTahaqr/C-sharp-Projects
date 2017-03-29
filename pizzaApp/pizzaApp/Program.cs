using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaApp
{
    class Program
    {
        class pizzaSel
        {
            private string flavour;
            public string _flavour
            {
                get { return flavour; }
                set { flavour = value; }
            }
           

        }
        static void Main(string[] args)
        {
            pizzaSel pizzaShop = new pizzaSel();
            Console.WriteLine("Welcome to pizzaHut");
            Console.WriteLine("pizza flavour?");
            pizzaShop._flavour = Console.ReadLine();
            Console.WriteLine("pizza Size?");
                    



        }
    }
}
