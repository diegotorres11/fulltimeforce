using Autofac;
using Fulltimeforce.UI.Startup;
using System.Windows;

namespace Fulltimeforce.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstraper = new Bootstrapper();
            var container = bootstraper.Bootstrap();

            var employeeWindow = container.Resolve<EmployeeWindow>();

            employeeWindow.Show();
        }
    }
}
