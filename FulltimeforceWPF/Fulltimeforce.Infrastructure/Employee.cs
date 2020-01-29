using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fulltimeforce.Infrastructure
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double HourlyRate { get; set; }

        [Required]
        public int MonthlyWorkedHours { get; set; }

        [Required]
        public int WorkingYears { get; set; }

        public double GrossPayment { get; set; }
        public double Deduction { get; set; }
        public double FinalPayment { get; set; }
    }
}
