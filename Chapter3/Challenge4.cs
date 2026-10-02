using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Challenge4
    {
        public static void main(string [] args)
        {
            Console.WriteLine("Enter your Password");
            string pswd= Console.ReadLine();
            // != --> NOT EQUALS
            // THE LOOP RUNS UNTIL pswd is not equal to "Agile123"
            while (pswd != "Agile123")
            {
                Console.WriteLine("PASSWORD IS INCORRECT!!");
                Console.WriteLine("Enter your Password");
                pswd = Console.ReadLine();
            }
            Console.WriteLine("Password is CORRECT");
        }
    }
}
