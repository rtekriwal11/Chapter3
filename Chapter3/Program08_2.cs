using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program08_2
    {
        public static void main(string[] args)
        {
            //OBJECT OF CAR CLASS
            Car c1 = new Car("Toyota", "Red", 0);
            Console.WriteLine(c1);
            c1.Accelerate(50);
            Console.WriteLine(c1);
        }
    }
}
