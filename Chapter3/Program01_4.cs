using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    /*Write a Program to ask the user for 2 numbers
     *,and then ask them which operation they want to do on 
     * the numbers (ADD, SUB, MUL, DIVIDE) together given by the 
     * user. Repeat this operation 3 times.
     */
    internal class Program01_4
    {
        public static void main(string[] args)
        {
            //ASK THE USER FOR 2 NUMBERS
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number");
            int num2 = int.Parse(Console.ReadLine());
            //DISPLAY THE MENU TO THE USER 
            Console.WriteLine("OPERATIONS MENU");
            Console.WriteLine("1.ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIPLY");
            Console.WriteLine("4. DIVIDE");
            performOperation(num1, num2);
        }
        public static void performOperation(int num1, int num2)
        {
            //ASK THE USER FOR THE OPERATION NUMBER TO BE
            //PERFORMED
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the operation number");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:ADD_2NUM(num1, num2);
                        break;
                    case 2:SUB_2NUM(num1,num2);
                        break;
                    case 3:MUL_2NUM(num1,num2);
                        break;
                    case 4:DIV_2NUM(num1,num2);
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT!!");
                        break;
                }
            }
        }

        public static void ADD_2NUM(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum is:" + sum);
        }

        public static void SUB_2NUM(int num1, int num2)
        {
            int difference = num1 - num2;
            Console.WriteLine("The difference is:" + difference);
        }

        public static void MUL_2NUM(int num1, int num2)
        {
            int mul = num1 * num2;
            Console.WriteLine("The product is:" + mul);
        }

        public static void DIV_2NUM(int num1, int num2)
        {
            int div = num1 / num2;
            Console.WriteLine("The quotient is:" + div);
        }
    }
}
