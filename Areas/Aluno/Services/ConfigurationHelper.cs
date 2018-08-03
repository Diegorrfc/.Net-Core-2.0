using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaDotNetCore.Areas.Aluno.Services
{
    public static class ConfigurationHelper
    {
        public static IConfigurationRoot GetConfiguration(string path, string environmentName=null)
        {
            var builder = new ConfigurationBuilder().SetBasePath(path).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            if (!String.IsNullOrWhiteSpace(environmentName))
            {
                builder = builder.AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
            }
            builder = builder.AddEnvironmentVariables();
            return builder.Build();
        }
    }
}
