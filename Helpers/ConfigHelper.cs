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
        public static string GetEmail()
        {
            return GetConfig()["Email"];
        }
        public static string GetPassword()
        {
            return GetConfig()["Password"];
        }
        public static string GetAppVersion()
        {
            return GetConfig()["AppVersion"];
        }
    }
}
