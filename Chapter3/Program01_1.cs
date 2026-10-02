using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program01_1
    {
        public static void main(string[] args)
        {
            array_creation_display();
        }

        public static void array_creation_display()
        {
            //CREATING AN ARRAY OF SIZE 5
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            Console.WriteLine("THE NUMBERS ARE:");
            //PRINTING THE ANSWER TO THE USER
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
