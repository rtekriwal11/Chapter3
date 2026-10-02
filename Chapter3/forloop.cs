using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class forloop
    {
        public static void main(string[] args)
        {
            int num;
            //FOR LOOP ASK FOR 5 numbers
            //for(<initialisation, condition, increment step/decrement step)
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Enter your number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Your number was " + num);
            }
            Console.WriteLine("WE are done!!");

        }
    }
}
