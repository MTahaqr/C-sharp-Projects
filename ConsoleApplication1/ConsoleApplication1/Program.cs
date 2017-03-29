using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class user
        {
            public string names ;
        }
        static void Main(string[] args)
        {
            user[] obj = new user[5];
         //   obj[0].names = "Taha";
            obj[1].names = "Qadri";
            obj[2].names = "Rizvi";
            Console.WriteLine(obj[0].names, obj[1].names, obj[2].names);
            Console.ReadLine();
        }
    }
}
