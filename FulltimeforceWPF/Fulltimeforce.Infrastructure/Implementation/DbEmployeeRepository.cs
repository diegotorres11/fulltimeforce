using Fulltimeforce.Infrastructure.Abstract;

namespace Fulltimeforce.Infrastructure
{
    public class DbEmployeeRepository : IEmployeeRepository
    {
        public int Add(Employee employee)
        {
            using (var context = new JobContext())
            {
                context.Employees.Add(employee);

                return context.SaveChanges();
            }
        }
    }
}
