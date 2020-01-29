using Fulltimeforce.API.Abstract;

namespace Fulltimeforce.API.Infrastructure
{
    public class DbGradeRepository : IGradeRepository
    {
        private GradeContext _gradeContext;

        public DbGradeRepository(GradeContext gradeContext)
        {
            _gradeContext = gradeContext;
        }

        public int Add(Grade grade)
        {
            _gradeContext.Grades.Add(grade);

            return _gradeContext.SaveChanges();
        }
    }
}
