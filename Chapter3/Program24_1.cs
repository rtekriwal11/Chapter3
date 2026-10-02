using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a C# program that asks the user to enter their test score.
Display the following message:
90–100: Excellent!
80–89: Good job!
70–79: You passed.
Below 70: You need to practice more.
Example:
Enter your test score: 85
Good job!
Concept: if, else if, else
 */
namespace Chapter3
{
    internal class Program24_1
    {
        public static void main(string[] args)
        {
            int score;
            Console.WriteLine("Enter your test score: ");
            score = int.Parse(Console.ReadLine());
            if (score >= 90 && score <=100)
            {
                Console.WriteLine("Excellent!");
            }
            else if (score >= 80 && score <=89)
            {
                Console.WriteLine("Good job!");
            }
            else if (score >= 70 && score <=79)
            {
                Console.WriteLine("You passed.");
            }
            else if (score >=0 && score < 70)
            {
                Console.WriteLine("You need to practice more.");
            }
            else
            {
                Console.WriteLine("Invalid score entered.");
            }
        }
    }
}
