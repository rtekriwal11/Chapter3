using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Graduate: Student
    {
        // constructor

        public Graduate(string studentId, string name, int score)
        : base(studentId, name, score)
        {
        }
        // method

        public string GetLetterGrade()
        {
            string letterGrade;
            if (Score >= 95)
                letterGrade = "A";
            else if (Score >= 85)
                letterGrade = "B";
            else if (Score >= 75)
                letterGrade = "C";
            else if (Score >= 65)
                letterGrade = "D";
            else
                letterGrade = "F";
            return letterGrade;
        }

        public override string ToString()
        {
            string str;
            str = base.ToString() + $" Letter grade: {GetLetterGrade()}";
            return str;
        }
    }
}
