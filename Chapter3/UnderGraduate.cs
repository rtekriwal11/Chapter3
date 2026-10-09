using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class UnderGraduate : Student
    {
        public UnderGraduate(string studentId, string name, int score): base(studentId, name, score)
        {

        }

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
            return $"{base.ToString()}, Letter Grade: {GetLetterGrade()}";
        }

    }
}
