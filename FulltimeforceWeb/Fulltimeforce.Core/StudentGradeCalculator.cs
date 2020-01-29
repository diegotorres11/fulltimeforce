using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fulltimeforce.Core
{
    public class StudentGradeCalculator
    {
        public GradeResult Calculate(params int[] grades)
        {
            return new GradeResult
            {
                PassingGrades = CountPassingGrades(grades),
                FailingGrades = CountFailingGrades(grades),
                Average = CalculateAverage(),
                AveragePassingGrades = CalculateAveragePassingGrades(grades),
                AverageFailingGrades = CalculateAverageFailingGrades(grades)
            };
        }

        public int CountPassingGrades(params int[] grades)
        {
            return grades.Count(grade => grade >= 51);
        }

        public int CountFailingGrades(params int[] grades)
        {
            return grades.Count(grade => grade < 51);
        }

        public double CalculateAverage(params int[] grades)
        {
            return grades.Average();
        }

        public double CalculateAveragePassingGrades(params int[] grades)
        {
            return grades.Where(grade => grade >= 51).Average();
        }

        public double CalculateAverageFailingGrades(params int[] grades)
        {
            return grades.Where(grade => grade < 51).Average();
        }
    }
}
