using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        class Manager
        {
            public string projectName  = "Blood Management" ;
            public void  print(SwipeCard obj)
            {
                Console.WriteLine("Swipe card inf in manger class "+ obj.amount);
            }
        }

        class SwipeCard
        {
            public int amount = 1000000;
            public void  print(Manager obj)
            {
                Console.WriteLine("Manager Inf in Swipe Card" +obj.projectName);
            }
        }
        static void Main(string[] args)
        {
           SwipeCard swipeCardObj = new SwipeCard();
            Manager managerObj = new Manager();
            swipeCardObj.print(managerObj);
            managerObj.print(swipeCardObj);
            Console.ReadKey();

        }
    }
}
