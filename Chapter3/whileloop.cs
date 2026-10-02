using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class whileloop
    {
        public static void main(string[] args)
        {
            //WHILE LOOP
            Console.WriteLine("Enter your score");
            int num = int.Parse(Console.ReadLine());
            // WHILE LOOP WITH CONDITION TO ASK THE USER
            //FOR THE NUMBER AGAIN AND AGAIN UNTIL HE ENTERS
            // MORE THAN 90
            //RUN THE LOOP UNTIL NUM IS ABOVE 90
            while (num <90)
            {
                Console.WriteLine("You Entered the Less score");
                Console.WriteLine("Enter your score");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your Number entered is More than equal to 90");

        }
    }
}
