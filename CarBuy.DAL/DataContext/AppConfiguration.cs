using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace CarBuy.DAL.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration ()
        {
            var configBulder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBulder.AddJsonFile(path, false);
            var root = configBulder.Build();
            var appSettings = root.GetSection("ConnectionString:DefaultConnection");
            sqlConnectionString = appSettings.Value;
        }
        public string sqlConnectionString { get; set; }
    }
}
