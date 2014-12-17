using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OmniCodedUITest.Libraries;
using OmniCodedUITest.UIMaps.InstallerUIMapClasses;
using OmniCodedUITest.Config;
using OmniCodedUITest.Resources;

namespace OmniCodedUITest.Scripts
{
    /// <summary>
    /// Summary description for Installer
    /// </summary>
    [CodedUITest]
    public class InstallerScripts : PersonifyScriptsBase
    {
        public InstallerScripts()
        {
        }

        #region TestInitialize
        /// <summary>
        /// Use ClassInitialize to run code before start running test 
        /// </summary>
        //[ClassInitialize()]
        //public void ClassInitialize()
        //{
        //    base.ClassInitialize("InstallerPath", "InstallerName", "RunningProcessName");
        //}

        /// <summary>
        /// Use TestInitialize to run code before running each test 
        /// </summary>
        [TestInitialize()]
        public override void TestInitialize()
        {
            //PersonifyInstance.start(AppConfig.GetValue("InstallerPath"), AppConfig.GetValue("InstallerName"), AppConfig.GetValue("InstallerName"));
            //Personify.InstallerUI = new InstallerUIMap();
            //PlaybackSettings();            
            //base.TestInitialize();
            base.TestInitialize(true);
        }
        
        #endregion
        #region TestCleanUp

        [TestCleanup()]
        public override void TestCleanup()
        {
            Personify.InstallerUI = new InstallerUIMap();
            base.TestCleanup();
        }
        #endregion
        #region Testscripts
        /// <summary>
        /// This method automatically execute steps to install Personify via Installer.
        /// Note: Must turn off UAC to run this method.(Support UAC is on: TBD)
        /// </summary>
        [TestMethod]
        public void testSimplestInstaller()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            try { Installer.installPersonify(); }
            finally {
                this.TestCleanup();
            }
            
        }
        #endregion



    }
}
