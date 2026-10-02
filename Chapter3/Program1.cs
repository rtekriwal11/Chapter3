using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program1
    {
        public static void main(string[] args)
        {
            //CONDITIONAL STATEMENTS
            // IF ELSE STATEMENTS
            //QUESTION; ASK THE USER FOR HIS NAME AND ASK FOR HIS AGE
            // IF THE AGE IS MORE THAN 16, PRINT "YOU SHOULD BE IN COLLEGE"
            //ELSE PRINT " YOU SHOULD BE IN SCHOOL"

            //1. Ask the user for his name
            Console.WriteLine("Enter your name");
            //2. Store the name in a variable
            string name= Console.ReadLine();
            //3. Ask the user for his age
            Console.WriteLine("Enter your age");
            //4. Store the name in a variable
            int age = int.Parse(Console.ReadLine());
            //5. Define the condition
            if(age > 16)
            {
                Console.WriteLine("You should be in college");
            }
            else
            {
                Console.WriteLine("You should be in school");
            }
        }
    }
}
