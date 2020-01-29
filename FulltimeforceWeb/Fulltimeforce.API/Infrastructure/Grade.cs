using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fulltimeforce.API.Infrastructure
{
    public class Grade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Grades { get; set; }
        public int PassingGrades { get; set; }
        public int FailingGrades { get; set; }
        public double Average { get; set; }
        public double AveragePassingGrades { get; set; }
        public double AverageFailingGrades { get; set; }
    }
}
