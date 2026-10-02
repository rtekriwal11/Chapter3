using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program01_2
    {
        //ASK THE USER FOR 2 numbers
        // and add them
        //and display the answer

        public static void main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers to add");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int answer=sum(num1, num2);
            display(answer);
        }
        public static void display(int answer)
        {
            Console.WriteLine("The sum is:" + answer);
        }
        public static int sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
