using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix movieOne = new Netflix();
            movieOne.Name = "Movie One";
            movieOne.Genre = "Comedy";
            movieOne.Rating = 4;
            movieOne.GetNetflix();

            if (movieOne.Rating >= 4)
            {
                Console.WriteLine("This is an OKAY movie");
            }
            else
            {
                Console.WriteLine("This movie SUCKED");
            }
            Console.ReadLine();
        }
    }
}
