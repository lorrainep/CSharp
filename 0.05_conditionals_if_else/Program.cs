using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreInIt = true;
            int elevatorNumber = 13;

            if (elevatorUp == true)
            {
                //do stuff
                Console.WriteLine("Going up");
            }
            else
            {
                //do something else
                Console.WriteLine("Going down");
            }
            if (elevatorBroken)
            {
                Console.WriteLine("Panic!!");
            }
            else
            {
                Console.WriteLine("Nice elevator");
            }

            if (elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Let's go Diehard in this elevator shaft!!");
                Console.WriteLine("Yea, let's climb the cord!");
            }
            else
            {
                Console.WriteLine("Do you have those TPS reports for me?");
            }

            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("Oh no..");
            }
            else
            {
                Console.WriteLine("Man, Wish this was broken");
            }

            if (elevatorBroken || elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Dude, we're in Mexico. We're in 4th grade. We're stuck on an elevator.");
            }

            if (elevatorNumber == 13)
            {
                Console.WriteLine("Scared");
            }

            if (elevatorNumber == 13 && elevatorStuckWhileWeAreInIt)
            {
                Console.WriteLine("Not our lucky day");
            }


            Console.ReadLine();






        }



    }
}
