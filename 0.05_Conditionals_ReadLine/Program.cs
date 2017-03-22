using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if(feelingNumber == "5")
            {
                Console.WriteLine("Wow, man. That's great to hear.");
            }
            if (feelingNumber >="1" || feelingNumber <= "5")   
            {
                Console.WriteLine("Ah man the feels!");
            }
            else
            {
                Console.WriteLine("I said guess between 1-5");
            }
       
       
            
            Console.ReadLine();

        }
    }
}
