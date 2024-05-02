using Autofac;
using EmployeeDirectoryWPF.Services;
using EmployeeDirectoryWPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryWPF
{
    public class AppModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindowViewModel>().SingleInstance();
            builder.RegisterType<MyDbContext>().As<DbContext>().InstancePerLifetimeScope();
            builder.RegisterType<App>().AsSelf().SingleInstance();
        }
    }
}
