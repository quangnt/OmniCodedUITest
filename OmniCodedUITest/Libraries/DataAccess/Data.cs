using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniCodedUITest.Scripts;

namespace OmniCodedUITest.Libraries.DataAccess
{
    public class Data
    {
        public static string GetValue(string columnName)
        {
            return (string)PersonifyScriptsBase.PersonifyTestContext.DataRow[columnName];
        }
    }
}
