using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using CarBuy.DAL.EF;

namespace CarBuy.DAL.DataContext
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfiguration = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            opsBuilder.UseSqlServer(appConfiguration.sqlConnectionString);
            return new AppDbContext(opsBuilder.Options);
            
        }
    }
}
