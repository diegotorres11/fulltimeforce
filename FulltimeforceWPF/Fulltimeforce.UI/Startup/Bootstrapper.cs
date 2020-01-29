using Autofac;
using Fulltimeforce.Infrastructure;
using Fulltimeforce.Infrastructure.Abstract;
using Fulltimeforce.UI.ViewModel;

namespace Fulltimeforce.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeWindow>().AsSelf();
            builder.RegisterType<EmployeeViewModel>().AsSelf();
            builder.RegisterType<DbEmployeeRepository>().As<IEmployeeRepository>();

            return builder.Build();
        }
    }
}