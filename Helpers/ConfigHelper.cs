using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OMNEX.AUTOMATION.Helpers
{
    public static class ConfigHelper
    {
        public static IConfiguration GetConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(System.AppContext.BaseDirectory).AddJsonFile("EnvironmentSettings.json", optional: true, reloadOnChange: true);
            return builder.Build();            
        }

        public static void ModifyRegisteredEmail(String value)
        {
            GetConfig()["RegisteredEmail"] = value;
        }
        public static string GetEnvironment()
        {
            return GetConfig()["Environment"];
        }
        public static string GetBrowser()
        {
            return GetConfig()["Browser"];
        }
        public static string GetURL()
        {
            return GetConfig()["URL"];
        }
        public static string GetAPIBaseURL()
        {
            return GetConfig()["BaseURL"];
        }
        public static string GetLogSwitch()
        {
            return GetConfig()["LogSwitch"];
        }
        public static string GetLogLanguage()
        {
            return GetConfig()["LogLanguage"];
        }
        public static string GetFailLogLanguage()
        {
            return GetConfig()["FailLogLanguage"];
        }
        public static string GetThaniUser()
        {
            return GetConfig()["ThaniUser"];
        }
        public static string GetPassword()
        {
            return GetConfig()["Password"];
        }

        public static string AdminPassword()
        {
            return GetConfig()["AdministratorPassword"];
        }

        public static string GetAppVersion()
        {
            return GetConfig()["AppVersion"];
        }
        public static string GetRightsUser()
        {
            return GetConfig()["RightsUser"];
        }
        public static string GetDocProUser()
        {
            return GetConfig()["DocProUser"];
        }
        public static string GetAdminUser()
        {
            return GetConfig()["AdminUser"];
        }
        public static string GetFSQA()
        {
            return GetConfig()["FSQA"];
        }

        public static string Dummy()
        {
            return GetConfig()["Dummy"];
        }

        public static string NoAccess()
        {
            return GetConfig()["Noaccess"];
        }

        public static string Administrator()
        {
            return GetConfig()["AdminUser"];
        }

    }
}
