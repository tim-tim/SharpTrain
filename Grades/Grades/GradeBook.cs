using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        // initialization with constructor
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            // create local stats object to store (and return later) the results of computation
            GradeStatistics stats = new GradeStatistics();            

            // create local var sum to store sum of all grades in list
            float sum = 0;
            foreach (float grade in grades)
            {
                // Math class' Max and Min methods are used to calculate max and min values
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            // calculation of average grade
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        private List<float> grades;
    }
}
