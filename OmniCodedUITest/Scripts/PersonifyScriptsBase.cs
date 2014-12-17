using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OmniCodedUITest.Config;
using OmniCodedUITest.Libraries;
using OmniCodedUITest.UIMaps.LoginUIMapClasses;
using OmniCodedUITest.UIMaps.MainControlPanelClasses;

namespace OmniCodedUITest.Scripts
{
    /// <summary>
    /// Summary description for PersonifyScriptsBase
    /// </summary>
    [CodedUITest]
    public class PersonifyScriptsBase
    {
        #region Personify Scripts Base properties       

        public static TestContext personifyTestContext;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public static TestContext PersonifyTestContext
        {
            get { return PersonifyScriptsBase.personifyTestContext; }
            set { PersonifyScriptsBase.personifyTestContext = value; }
        }
        
        public PersonifyScriptsBase()
        {
        }

        /// <summary>
        /// Confugure the Global Playback Settings
        /// </summary>
        /// 
        private void PlaybackSettings(bool isinstaller)
        {
            PlaybackConfig.SetWaitForReadyLevel();
            PlaybackConfig.SetThinkSearchTimeOut();
            if (isinstaller == false)
            {
                PlaybackConfig.SetWaitForReadyTimeout();
            }
            else 
            {
                PlaybackConfig.SetWaitForReadyTimeoutInstaller();
            }
            PlaybackConfig.SetDelayBetweenActions();
            PlaybackConfig.SetShouldSearchFailFast();
            PlaybackConfig.RemoveErrorHandler();
            PlaybackConfig.AddErrorHandler();
            PlaybackConfig.SetSearchInMinimizedWindows();
            PlaybackConfig.SetMatchExactHierarchy();
            PlaybackConfig.SetContinueOnError();
            PlaybackConfig.SetSmartMatchOptions();
            //PlaybackConfig.SetThinkTimeMultiplier();
        }

        /// <summary>
        /// Confugure the Global Playback Settings
        /// </summary>
        private void PlaybackSettings()
        {
            PlaybackConfig.SetWaitForReadyLevel();
            PlaybackConfig.SetThinkSearchTimeOut();
            PlaybackConfig.SetWaitForReadyTimeout();
            PlaybackConfig.SetDelayBetweenActions();
            PlaybackConfig.SetShouldSearchFailFast();
            PlaybackConfig.RemoveErrorHandler();
            PlaybackConfig.AddErrorHandler();
            PlaybackConfig.SetSearchInMinimizedWindows();
            PlaybackConfig.SetMatchExactHierarchy();
            PlaybackConfig.SetContinueOnError();
            PlaybackConfig.SetSmartMatchOptions();
            //PlaybackConfig.SetThinkTimeMultiplier();
        }

        
        #endregion



        #region TestInitialize
        /// <summary>
        /// Use ClassInitialize to run code before start running test 
        /// </summary>
        //[ClassInitialize()]
        //public virtual void ClassInitialize(string path, string filename, string processname) 
        //{            
        //    PersonifyInstance.start(AppConfig.GetValue(path), AppConfig.GetValue(filename), AppConfig.GetValue(processname));            
        //    PlaybackSettings();
        //}
        //[ClassInitialize()]
        //public virtual void ClassInitialize()
        //{
        //    PersonifyInstance.start(AppConfig.GetValue("InstalledPath"), AppConfig.GetValue("InstalledName"), AppConfig.GetValue("RunningProcessName"));
        //    PlaybackSettings();
        //}

        /// <summary>
        /// Use TestInitialize to run code before running each test 
        /// </summary>
        [TestInitialize()]
        public virtual void TestInitialize()
        {
            
            PersonifyInstance.start(AppConfig.GetValue("InstalledPath"), AppConfig.GetValue("InstalledName"), AppConfig.GetValue("RunningProcessName"));
            Personify.LoginUI = new LoginUIMap();
            Personify.MainControlPanelUI = new MainControlPanel();
            PlaybackSettings();
            PersonifyTestContext = testContextInstance;
        }

        public virtual void TestInitialize(bool isinstaller)
        {
            if (isinstaller == false)
            {
                PersonifyInstance.start(AppConfig.GetValue("InstalledPath"), AppConfig.GetValue("InstalledName"), AppConfig.GetValue("RunningProcessName"));
            }
            else 
            {
                PersonifyInstance.start(AppConfig.GetValue("InstallerPath"), AppConfig.GetValue("InstallerName"), AppConfig.GetValue("InstallerName"));
            }
            Personify.LoginUI = new LoginUIMap();
            Personify.MainControlPanelUI = new MainControlPanel();
            PlaybackSettings(isinstaller);            
            PersonifyTestContext = testContextInstance;
        }

        
        #endregion

        #region TestCleanup
        /// <summary>
        /// Use ClassCleanup to run code after finish running all test cases
        /// </summary>
        //[ClassCleanup()]
        //public virtual void ClassCleanup()
        //{
        //    PersonifyInstance.Close();
        //}
        /// <summary>
        /// Use TestCleanup to run code after running each text
        /// </summary>
        [TestCleanup()]
        public virtual void TestCleanup()
        {
            Personify.LoginUI = new LoginUIMap();
            Personify.MainControlPanelUI = new MainControlPanel();
            PersonifyInstance.Close();
        }

        #endregion
        #region TestContext
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
        #endregion

        #region Test Scripts        
        #endregion
    }
}
