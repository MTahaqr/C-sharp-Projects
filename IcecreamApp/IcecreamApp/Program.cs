using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcecreamApp
{
    class Program
    {
        class icecreamSel
        {
            private string flavour;
            public string _flavour
            {
                get
                {
                    return flavour;
                }
                set
                {
                    flavour = value;
                }
            }
            private int scoope;
            public int _scoope
            {
                get
                {
                    return scoope;
                }
                set
                {
                    scoope = value;
                }
            }

            private string wapers;
            public string _wapers
            {
                get
                {
                    return wapers;
                }
               set
                {
                    wapers = value;
                }
            }
            private int totalPrice = 0;
            public int _totalPrice
            {
                get
                {
                    return totalPrice;
                }
                set
                {
                    totalPrice = value;
                }
            }

            public void priceCal()
            {
                if (scoope == 3 || scoope == 2)
                {
                    if (flavour == "Chocolate")
                        totalPrice = scoope * 60;
                    else
                        totalPrice = scoope * 50;
                    if (wapers == "yes")
                    {
                        totalPrice += 10;
                    }
                }
                else
                    Console.WriteLine("Sorry, something wrong PLz try again later.");
            }
            public void print()
            {
                if (scoope == 3 || scoope == 2)
                    Console.WriteLine("\n Ur IceCream Reaquirement: \n\n Flavour : "+ flavour +" \n Num Of Scoopes : "+ scoope + "\n Wafers : " + wapers +"\n Total Price : " + totalPrice);
                    Console.WriteLine("\n\n Thankyou for visiting IGLOO IceCream ;-)");
            }



        }
        
        static void Main(string[] args)
        {
            icecreamSel iceShop = new icecreamSel();
            Console.WriteLine("Welcome to IGLOO");
            Console.WriteLine("iceCrea flavour ?");
            iceShop._flavour = Console.ReadLine();
            Console.WriteLine("Num of scoopes ?");
            iceShop._scoope = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wapers ? (Yes/NO)");
            iceShop._wapers = Console.ReadLine();
            iceShop.priceCal();
            iceShop.print();
            Console.ReadKey();

        }
    }
}
