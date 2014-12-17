using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniCodedUITest.Libraries
{
    class Installer
    {        
        /// <summary>
        /// This method automatically execute steps to install Personify via Installer.
        /// Note: Must turn off UAC to run this method.(Support UAC is on: TBD)
        /// </summary>
        public static void installPersonify()
        {
            //Personify.InstallerUI.iAgreeButton.WaitForControlEnabled();
            //Mouse.Click(Personify.InstallerUI.iAgreeButton);
            //Personify.InstallerUI.progressBar.WaitForControlExist();
            //Personify.InstallerUI.progressBar.WaitForControlNotExist();
            //Personify.InstallerUI.UIPersonifySetupWindow.SetFocus();
            Personify.InstallerUI.UIPersonifySetupWindow.UIIAgreeWindow.UIIAgreeButton.WaitForControlEnabled();
            Mouse.Click(Personify.InstallerUI.UIPersonifySetupWindow.UIIAgreeWindow.UIIAgreeButton);
            Personify.InstallerUI.UIPersonifySetupWindow.UIProgressbarWindow.WaitForControlExist();
            Personify.InstallerUI.UIPersonifySetupWindow.UIProgressbarWindow.WaitForControlNotExist();
            //Mouse.Click(this.UIPersonifySetupWindow.UIIAgreeWindow);
            //this.UIPersonifySetupWindow.UIProgressbarWindow.WaitForControlExist();
            //this.UIPersonifySetupWindow.WaitForControlNotExist();
        }

        public static void installPersonifySilent()
        { 
            
        }
    }
}
