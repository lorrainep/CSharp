using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public int TotalMinutes { get; set; }

        //Public Void
        public void GetNetflix()
        {
            Console.WriteLine("I have watched {0}", Name);
        }
        public int ShowRuntime()
        {
            Console.WriteLine(this.TotalMinutes);
            return this.TotalMinutes;
        }
    }

}
