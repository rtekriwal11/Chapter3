using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Car
    {
        //FIELDS/ ATTRIBUTES 
        private string brand;
        private string color;
        private int speed;

        //GETTERS AND SETTERS
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        //CONSTRUCTOR
        public Car(string brand, string color, int speed)
        {
            Brand= brand;
            Color = color;
            Speed = speed;
        }

        public void Accelerate(int increment)
        {
            Speed = Speed + increment;
        }

        public override string ToString()
        {
            return $"Car Brand: {Brand}, Color: {Color}, Speed: {Speed} km/h";
        }
    }
}
