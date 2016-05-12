using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Highes grade is {0}",stats.HighestGrade);
            Console.WriteLine("Lowest grade is {0}",stats.LowestGrade);
            Console.WriteLine("Average grade is {0}",stats.AverageGrade);

        }
    }
}
