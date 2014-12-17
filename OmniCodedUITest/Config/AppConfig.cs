using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OmniCodedUITest.Config
{
    class AppConfig
    {
        /// <summary>
        /// Get the value corresponding to the key from App.config settings
        /// </summary>
        /// <param name="key">The key name</param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
