using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace OmniCodedUITest.Libraries
{
    class NetworkConditions
    {
        // Disable Network in Window network interface ( Need to retest this before using)
        public static void DisableNetwork()
        {
            ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection mgmtObjectColl = managementClass.GetInstances();
            ManagementObject myObject = null;
            foreach (ManagementObject mgmtObject in mgmtObjectColl)
            {
                if (mgmtObject["NetConnectionID"] != null && mgmtObject["NetConnectionID"].Equals("Local Area Connection"))
                {
                    myObject = mgmtObject;
                    object result = mgmtObject.InvokeMethod("Disable", null);
                }
            }
        }

        // Enable Network in Window network interface ( Need to retest this before using)
        public static void EnableNetwork()
        {
            ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection mgmtObjectColl = managementClass.GetInstances();
            ManagementObject myObject = null;
            foreach (ManagementObject mgmtObject in mgmtObjectColl)
            {
                if (mgmtObject["NetConnectionID"] != null && mgmtObject["NetConnectionID"].Equals("Local Area Connection"))
                {
                    myObject = mgmtObject;

                }
            }
            object result3 = myObject.InvokeMethod("Enable", null);
        }
    }
}
