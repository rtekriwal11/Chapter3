using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class shippingcost
    {
        public static void main(string[] args)
        {
            const double book_cost = 3.25;
            const double shipping_cost = 5.00;
            double total;
            //PROMPT THE USER FOR THE NUMBER OF BOOKS
            Console.WriteLine("Enter the number of books");
            //COUNT OF BOOKS ENTERED BY USER
            int num_of_books= int.Parse(Console.ReadLine());
            //CALCULATE THE TOTAL COST OF THE BOOKS BOUGHT
            double total_book_cost = book_cost * num_of_books;
            if(total_book_cost>= 30)
            {
                total = total_book_cost;
            }
            else
            {
                total = total_book_cost+ shipping_cost;
            }
            Console.WriteLine("The total cost is " + total);
        }
    }
}
