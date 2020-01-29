using Fulltimeforce.API.Infrastructure;
using Fulltimeforce.Core;

namespace Fulltimeforce.API.Mapping
{
    public class GradeMapper
    {
        public static Grade Map(GradeResult result, int[] grades)
        {
            var grade = new Grade
            {
                Grades = string.Join(',', grades),
                PassingGrades = result.PassingGrades,
                FailingGrades = result.FailingGrades,
                Average = result.Average,
                AveragePassingGrades = result.AveragePassingGrades,
                AverageFailingGrades = result.AverageFailingGrades
            };

            return grade;
        }
    }
}
