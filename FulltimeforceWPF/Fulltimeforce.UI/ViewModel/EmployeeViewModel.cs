using Fulltimeforce.Core;
using Fulltimeforce.Infrastructure.Abstract;

namespace Fulltimeforce.UI.ViewModel
{
    public class EmployeeViewModel
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeViewModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Employee { get; set; }

        public void Save()
        {
            //Automapper can be used here
            Infrastructure.Employee employee = new Infrastructure.Employee
            {
                Name = Employee.Name,
                HourlyRate = Employee.HourlyRate,
                WorkingYears = Employee.WorkingYears,
                MonthlyWorkedHours = Employee.MonthlyWorkedHours,
                GrossPayment = Employee.CalculateGrossPayment(),
                Deduction = Employee.CalculateDeductions(),
                FinalPayment = Employee.CalculateFinalPayment()
            };

            _employeeRepository.Add(employee);
        }
    }
}
