using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Conditionals_if
{
    class Program
    {
        static void Main(string[] args)
        {/*
            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on.");
            }
            */
           

            bool isAdmin = true;
            bool isLoggedIn = true;

                if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("Welcome to the site Admin");
            }
            Console.ReadLine();
        } 
    } 
}
