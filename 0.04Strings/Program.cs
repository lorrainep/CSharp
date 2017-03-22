using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            string occupation;

            firstName = "Lorraine";
            middleName = "May";
            lastName = "Papczynski";
            occupation = "Nothing";
            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);

            Console.ReadLine();
        }
    }
}
