using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ASk the user for a number
// and check if the number is 1 or 2 then print "I got one of the first 2 spots"
// else print " I didn't got the first 2 spots"

namespace Chapter3
{
    internal class Program24_2
    {
        public static void main(String[] args)
        {
            //ASK THE USER FOR A NUMBER
            Console.WriteLine("Enter a number");
            int num= int.Parse(Console.ReadLine());
            //CHECK IF THE NUMBER IS 1 OR 2
            if(num == 1 || num == 2)// || LOGICAL OR OPERATOR TO CHECK IF
                //EITHER OF THE CONDITION IS TRUE OR NOT
            {
                Console.WriteLine("I got one out of the first 2 spots");
            }
            else
            {
                Console.WriteLine("I didn't get one of the first 2 spots");
            }
        }
    }
}
