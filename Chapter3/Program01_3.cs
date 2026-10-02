using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter3
{
    internal class Program01_3
    {
        //ASK THE USER FOR A NAME
        //ASK IT HOW MANY TIIMES THE NAME
        //SHOULD BE PRINTED
        //PRINT THE RESULT
        public static void main(string[] args)
        {
            //ASK THE USER FOR A NAME
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            int num=print_names(name);
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name);
            }
        }

        public static int print_names(string name)
        {
            Console.WriteLine("How many times");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
