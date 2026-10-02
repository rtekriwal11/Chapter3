using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WORKING WITH ARRAYS
namespace Chapter3
{
    internal class Program24_3
    {
        public static void main(String[] args)
        {
            Console.WriteLine("Enter the size of the array");
            //GETTING THE SIZE OF ARRAY
            int size = int.Parse(Console.ReadLine());
            //CREATING AN ARRAY;
            int[] arr = new int[size];
            //METHOD FOR STORING THE NUMBERS
            //INTO ARRAY
            store_nums_into_array(arr, size);
            Console.WriteLine("The numbers you entered are");
            print_nums(arr, size);
            
        }

        public static void store_nums_into_array(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number");
                //READING THE NUMBER FROM THE USER
                // AND STORING IT IN THE ARRAY ACCORDING
                // TO THE INDEX i
                //MEMORY LOCATION STARTS FROM 0 Till 4
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void print_nums(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
