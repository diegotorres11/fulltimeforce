using Fulltimeforce.Core;
using Fulltimeforce.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fulltimeforce.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        private EmployeeViewModel _employeeViewModel;

        public EmployeeWindow(EmployeeViewModel employeeViewModel)
        {
            InitializeComponent();
            _employeeViewModel = employeeViewModel;
            
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            _employeeViewModel.Employee = new Employee
            {
                HourlyRate = double.Parse(txtHourlyRate.Text),
                Name = txtName.Text,
                WorkingYears = int.Parse(txtWorkingYears.Text),
                MonthlyWorkedHours = int.Parse(txtMonthlyWorkedHours.Text)
            };

            textName.Text = _employeeViewModel.Employee.Name;
            textHourlyRate.Text = _employeeViewModel.Employee.HourlyRate.ToString();
            textWorkingYears.Text = _employeeViewModel.Employee.WorkingYears.ToString();
            textGrossPayment.Text = _employeeViewModel.Employee.CalculateGrossPayment().ToString();
            textDeduction.Text = _employeeViewModel.Employee.CalculateDeductions().ToString();
            textFinalPayment.Text = _employeeViewModel.Employee.CalculateFinalPayment().ToString();

            _employeeViewModel.Save();
        }
    }
}
