using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;



namespace OmniCodedUITest.Scripts
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class TestExample : PersonifyScriptsBase
    {
        
        public TestExample()
        {
        }

        #region TestInitialize
        //Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public override void TestInitialize()
        //{
        //    //base.instance.ExecuteNameObject = "InstallerPath";
        //    //instance.ExecutePathObject = "InstallerName"; 
        //}
        #endregion
        //[TestMethod]
        //[DeploymentItem("Configuration.xml")]
        //public void CodedUITestMethod1()
        //{
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //    //string temp1 = omniinterface.personifyInstallerObject.InstalledPathObject;
        //    //string temp2 = omniinterface.personifyInstallerObject.InstallerPathObject;
        //    //return;         


        //}

        //[TestMethod]
        //public void CodedUTestMethod2() 
        //{
        //    //string temp1 = omniinterface.personifyInstallerObject.InstalledPathObject;
        //    //string temp2 = omniinterface.personifyInstallerObject.InstallerPathObject;
        //    //return;  
            
        //}
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}
        //private TestContext testContextInstance;
    }
}
