using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using CarBuy.DAL.Interfaces;
using CarBuy.DAL.Repositories;

namespace CarBuy.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
