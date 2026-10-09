using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program08_3
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            UnderGraduate ud1 = new UnderGraduate("111", "Lynn", 98);
            students.Add(ud1);
            UnderGraduate ud2 = new UnderGraduate("222", "Bob", 88);
            students.Add(ud2);
            Graduate g1 = new Graduate("333", "Chuck", 76);
            students.Add(g1);
            Graduate g2 = new Graduate("444", "Dan", 56);
            students.Add(g2);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
