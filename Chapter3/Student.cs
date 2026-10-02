using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Student
    {
        //FIELDS/ATTRIBUTES
        private string name;
        private int score;

        //SETTERS AND GETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        //CONSTRUCTOR
        //TO INTIALIZE THE FIELDS
        //WHEN CREATING AN OBJECT
        // OF STUDENT CLASS
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
        // method(s)
        public char GetLetterGrade()
        {
            char letterGrade;
            if (Score >= 90)
                letterGrade = 'A';
            else if (Score >= 80)
                letterGrade = 'B';
            else if (Score >= 70)
                letterGrade = 'C';
            else if (Score >= 60)
                letterGrade = 'D';
            else
                letterGrade = 'F';
            return letterGrade;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Letter Grade is:{GetLetterGrade()}";
        }
    }
}
