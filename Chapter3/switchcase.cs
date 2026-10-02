using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class switchcase
    {
        public static void main(string[] args)
        {
            //ASK THE USER FOR HIS MONTH NUMBER FOR BIRTH
            // AND PRINT HIS MONTH NAME

            //PROMPT THE USER FOR HIS MONTH NUMBER
            Console.WriteLine("Enter the month number");
            //STORE THE ANSWER IN A VARIABLE
            int month = int.Parse(Console.ReadLine());
            //RUN A SWITCH CASE CONDITION
            switch (month)
            {
                case 1:
                    Console.WriteLine("You were born in the month of January");
                    break;
                case 2:
                    Console.WriteLine("You were born in the month of February");
                    break;
                case 3:
                    Console.WriteLine("You were born in the month of March");
                    break;
                case 4:
                    Console.WriteLine("You were born in the month of April");
                    break;
                case 5:
                    Console.WriteLine("You were born in the month of May");
                    break;
                case 6:
                    Console.WriteLine("You were born in the month of June");
                    break;
                case 7:
                    Console.WriteLine("You were born in the month of July");
                    break;
                case 8:
                    Console.WriteLine("You were born in the month of August");
                    break;
                case 9:
                    Console.WriteLine("You were born in the month of September");
                    break;
                case 10:
                    Console.WriteLine("You were born in the month of October");
                    break;
                case 11:
                    Console.WriteLine("You were born in the month of November");
                    break;
                case 12:
                    Console.WriteLine("You were born in the month of December");
                    break;
                    //UNEXPECTED INPUT FROM THE USER
                default:
                    Console.WriteLine("Please Enter the number between 1-12");
                    break;
            }
        }
    }
}
