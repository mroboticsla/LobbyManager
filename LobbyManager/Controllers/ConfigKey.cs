using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LobbyManager.Controllers
{
    public static class ConfigKey
    {
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static String Encode(String key)
        {
            return Base64Encode(Reverse(key));
        }

        public static String Decode(String key)
        {
            return Reverse(Base64Decode(key));
        }

        public static String DecodeEnvironmentVariable(String variable)
        {
            String result = "";
            try
            {
                result = Decode(Environment.GetEnvironmentVariable(variable));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public static String DecodeConfigEnvironmentVariable(String variable)
        {
            String result = "";
            try
            {
                result = Decode(Environment.GetEnvironmentVariable(ConfigurationManager.AppSettings[variable]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public static String DecodeConfigVariable(String variable)
        {
            String result = "";
            try
            {
                result = Decode(ConfigurationManager.AppSettings[variable]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}