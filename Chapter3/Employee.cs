using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Employee
    {
        //FIELDS/ATTRIBUTES
        private string name;
        private double payRate;
        private double hoursWorked;

        //GETTERS AND SETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        //CONSTRUCTOR
        public Employee(string name, double payRate, double hoursWorked)
        {
            Name = name;
            PayRate = payRate;
            HoursWorked = hoursWorked;
        }

        public double GetPayAmount()
        {
            double payAmount = PayRate * HoursWorked;
            return payAmount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Pay Amount: ${GetPayAmount()}";
        }
    }
}
