using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Kenn";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("Hey Fred");
                    break;
                case "Kenn":
                    Console.WriteLine("Hey Kenn");
                    break;
                default:
                    Console.WriteLine("YOu hit the default");
                    break;
                
            }
            Console.ReadLine();
        }
    }
}
