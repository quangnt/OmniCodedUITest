namespace OmniCodedUITest.UIMaps.InstallerUIMapClasses
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Xml;
    using System.IO;

    
    public partial class InstallerUIMap
    {
        private string installerPath = null;
        public string InstallerPathObject
        {
            get
            {
                if (installerPath == null) 
                {
                    readConfigFile();
                }
                return installerPath;
            }
            set
            {
                installerPath = value;
            }
        }

        private string installedPath = null;
        public string InstalledPathObject
        {
            get
            {
                if (installedPath == null)
                {
                    readConfigFile();
                }
                return installedPath;
            }
            set
            {
                installedPath = value;
            }
        }
        // Automatically install Personify(assume that UAC must be turn off to run this method successfully)
        // Due to UAC turn on --> Need to be done later.
        public void installPersonify()
        {
            Mouse.Click(this.UIPersonifySetupWindow.UIIAgreeWindow);
            this.UIPersonifySetupWindow.UIProgressbarWindow.WaitForControlExist();
            this.UIPersonifySetupWindow.WaitForControlNotExist();
        }

        // Read config file of test project. ("Configuration.xml")
        public void readConfigFile()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream("Configuration.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("InstallerPath");
            installerPath = xmlnode[xmlnode.Count - 1].InnerText;
            xmlnode = xmldoc.GetElementsByTagName("InstalledPath");
            installedPath = xmlnode[xmlnode.Count - 1].InnerText;
        }       
    }
}
