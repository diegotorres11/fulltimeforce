namespace Fulltimeforce.Core
{
    public class Employee
    {
        public double HourlyRate { get; set; }
        public string Name { get; set; }
        public int WorkingYears { get; set; }
        public int MonthlyWorkedHours { get; set; }


        public double CalculateGrossPayment()
        {
            return HourlyRate * MonthlyWorkedHours + WorkingYears * 30;
        }

        public double CalculateDeductions()
        {
            return CalculateGrossPayment() * 0.13;
        }

        public double CalculateFinalPayment()
        {
            return CalculateGrossPayment() - CalculateDeductions();
        }
    }
}
