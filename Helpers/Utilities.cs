﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OMNEX.AUTOMATION.Data.WEB;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OMNEX.AUTOMATION.Helpers
{
    public class Utilities
    {
        #region Declaration
        private IWebDriver _driver;
        #endregion

        #region Constructor
        public Utilities()
        {
            
        }
        #endregion

        /// <summary>
        /// To create random number between a limit 
        /// </summary>
        /// <param name="limit">Any integer value</param>
        /// <returns>Random integer as string</returns>
        public string RandomNumberGenerator(int limit)
        {
            if (limit <= 0)
                throw new ArgumentException("Limit count must be greater than zero.");
            Random rnd = new Random();
            int minValue = (int)Math.Pow(10, limit - 1); 
            int maxValue = (int)Math.Pow(10, limit) - 1; 
            int number = rnd.Next(minValue, maxValue + 1); 
            return number.ToString();
        }

        /// <summary>
        /// To create random number phone between of limit 10 Digits 
        /// </summary>
        /// <param name="limit">Any integer value</param>
        /// <returns>Random integer as string</returns>
        public string RandomPhoneNumber()
        {
            Random rnd = new Random();
            long minValue = 1000000000L;
            long maxValue = 9999999999L;

            long phoneNumber = minValue + (long)(rnd.NextDouble() * (maxValue - minValue + 1));

            return phoneNumber.ToString("D10");
        }
        /// <summary>
        /// To create a random SSN number
        /// </summary>
        /// <returns></returns>
        public string RandomSSN()
        {
            Random random = new Random();

            // Generate random numbers for each part of the SSN
            int part1 = random.Next(100, 1000); // XXX
            int part2 = random.Next(10, 100);    // XX
            int part3 = random.Next(1000, 10000); // XXXX

            // Format the parts into a complete SSN string
            string ssn = $"{part1:D3}-{part2:D2}-{part3:D4}";

            return ssn;
        }

        /// <summary>
        /// To run command line commands
        /// </summary>
        /// <param name="command">Commands that needs to be executed</param>
        /// <returns>Ouput of the command as string</returns>
        public string RunCommandLine(string command)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                Arguments = "/C " + command,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            var cmd = Process.Start(startInfo);
            string output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            return output;
        }

        /// <summary>
        /// To run command line commands
        /// </summary>
        /// <param name="command">Commands that needs to be executed</param>
        /// <returns>Ouput of the command as string</returns>
        public string RunCommandLineWithInputs(string logincommand, string clientid, string clientsecret, string unlockcommand, string mspwsd)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            using (StreamWriter sw = cmd.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(logincommand);
                    Thread.Sleep(1000);
                    sw.WriteLine(clientid);
                    Thread.Sleep(1000);
                    sw.WriteLine(clientsecret);
                    Thread.Sleep(1000);
                    sw.WriteLine(unlockcommand);
                    Thread.Sleep(1000);
                    sw.WriteLine(mspwsd);
                }
            }
            string output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            return output;
        }

        /// <summary>
        /// Returns the folder path where the project is present in the system
        /// </summary>
        /// <returns>Returns folder path as string</returns>
        public string ProjectPath()
        {
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath.ToString();
        }

        /// <summary>
        /// Generates a random text that consists of alphabets with text length given as input
        /// </summary>
        /// <param name="length"></param>
        /// <returns>Random text value in the form of String</returns>
        public string GenerateRandomText(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        /// <summary>
        /// Generates a random text that consists of alphabets with text length given as input
        /// </summary>
        /// <param name="length"></param>
        /// <returns>Random text value in the form of String</returns>
        public string GenerateRandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_-";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        /// <summary>
        /// Decrypts the encrypted string
        /// </summary>
        /// <param name="encrString"></param>
        /// <returns>String</returns>
        public string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                decrypted = "";
            }
            return decrypted;
        }
        /// <summary>
        /// Returns the formatted date properly with leading zeroes 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public string GetFormattedDate(String date)
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(date, culture);
            String formatteddate = tempDate.ToString("MM/dd/yyyy");
            return formatteddate;
        }

        public string GetDateTimeWithTimeZone(String TimeZone)
        {
            // Define the Central Standard Time zone
            TimeZoneInfo centralTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZone);

            // Get the current time in the Central Time zone
            DateTime currentTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, centralTimeZone);


            DateTime startUtcTime = DateTime.UtcNow.AddMinutes(3);
            DateTime endUtcTime = DateTime.UtcNow.AddMinutes(6);
            string StartUtcTime = startUtcTime.ToString("HH:mm") + " AM";
            string EndUtcTime = endUtcTime.ToString("HH:mm") + " AM";

            return "";
        }
        //Added by Karthik for date addition
        public string DateAfterAddingDays(int noOfDays)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Present date --->" + date.ToString());
            String addedDate = date.AddDays(noOfDays).ToShortDateString();
            addedDate = GetFormattedDate(addedDate);
            Console.WriteLine("Added date --->" + addedDate);
            return addedDate;
        }
        // ended by karthik  for date addition
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ConvertStringtoInteger(string value)
        {
            int result;
            try
            {
                result = int.Parse(value);
            }
            catch
            {
                result = (int)Convert.ToInt64(Convert.ToDouble(value));
            }
            return result;
        }

        /// <summary>
        /// Function to extract the password substring from the content
        /// </summary>
        /// <param name="content"></param>
        /// <returns>string</returns>
        public string ExtractPassword(string content)
        {
            // Assuming the password format remains consistent as mentioned (?46)
            int startIndex = content.IndexOf("Password: ") + "Password: ".Length;
            int endIndex = content.IndexOf("<br/>", startIndex);

            if (startIndex >= 0 && endIndex >= 0)
            {
                int length = endIndex - startIndex;
                string passwordSubstring = content.Substring(startIndex, length);
                return passwordSubstring;
            }

            return null;
        }

        /// <summary>
        /// Function to extract the verify link from the email
        /// </summary>
        /// <param name="content"></param>
        /// <returns>string</returns>
        public string ExtractVerifyLink(string content)
        {
            // Assuming the password format remains consistent as mentioned (?46)
            int startIndex = content.IndexOf("href='") + "href='".Length;
            int endIndex = content.IndexOf("'>Verify", startIndex);

            if (startIndex >= 0 && endIndex >= 0)
            {
                int length = endIndex - startIndex;
                string linkSubstring = content.Substring(startIndex, length);
                return linkSubstring;
            }

            return null;
        }

        public string GenerateRandomEmail()
        {
            string username = GenerateRandomText(8);
            string domain = "gmail.com";
            string email = username + "@" + domain;
            return email;
        }

        /// <summary>
        /// To generate timestamp so that we can use for unique values
        /// </summary>
        /// <returns></returns>
        public string CurrentTime()
        {
            // Combine: ddMMyyyyHHmmss and ddMMyyyy
            string combinedString = DateTime.Now.ToString("ddMMyyyyHHmmss", CultureInfo.InvariantCulture);
            return combinedString;
        }

       
        /// <summary> 
        /// Returning project path can be used to add address in the files
        /// </summary>
        /// <returns></returns>
        public static String projectpath()
        {
            var path = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath;
        }

        public static void setGlobalValue(string variable, string value)
        {           
           string filePath = @"C:\Users\91759\source\repos\Omnex_E2E\Data\WEB\GlobalVariableJson.json";
           string jsonContent = File.ReadAllText(filePath);
           dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonContent);
           JToken jToken = jsonObj.SelectToken(variable);
           jToken.Replace(value);
           string updatedJsonString = jsonObj.ToString();
           File.WriteAllText(filePath, updatedJsonString);
        }

        public static string getGlobalValue(String variableName)
        {
            string filePath = "C:\\Users\\91759\\source\\repos\\Omnex_E2E\\Data\\WEB\\GlobalVariableJson.json";
            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using JsonDocument doc = JsonDocument.Parse(fs);
            JsonElement root = doc.RootElement;
            string name = root.GetProperty(variableName).GetString();           
            return name;
        }
    }
}
