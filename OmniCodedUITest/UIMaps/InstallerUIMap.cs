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
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    
    public partial class InstallerUIMap
    {
        #region Installer Controls

        public WinButton minimizeButton;
        public WinButton maximizeButton;
        public WinButton closeButton;
        public WinButton xButton;
        public WinButton iAgreeButton;
        public WinButton cancelButton;
        public WinButton backButton;
        public WinButton showdetailsButton;
        public WinText licenseAgreementText;
        public WinText pleasereviewthelicenText;
        public WinControl personifyLogo; 
        public WinProgressBar progressBar;
        #endregion

        #region Constructor
        public InstallerUIMap()
        {
            personifyLogo = UIPersonifySetupWindow.UIItemWindow.UIPersonifyLogo;
            minimizeButton = UIPersonifySetupWindow.UIPersonifySetupTitleBar.UIMinimizeButton;
            maximizeButton = UIPersonifySetupWindow.UIPersonifySetupTitleBar.UIMaximizeButton;
            xButton = UIPersonifySetupWindow.UIPersonifySetupTitleBar.UICloseButton;
            iAgreeButton = UIPersonifySetupWindow.UIIAgreeWindow.UIIAgreeButton;
            closeButton = UIPersonifySetupWindow.UIIAgreeWindow.UICloseButton;
            cancelButton = UIPersonifySetupWindow.UICancelWindow.UICancelButton;
            licenseAgreementText = UIPersonifySetupWindow.UILicenseAgreementWindow.UILicenseAgreementText;
            pleasereviewthelicenText = UIPersonifySetupWindow.UIPleasereviewthelicenWindow.UIPleasereviewthelicenText;
            progressBar = UIPersonifySetupWindow.UIProgressbarWindow.UIItemProgressBar;
            showdetailsButton = UIPersonifySetupWindow.UIShowdetailsWindow.UIShowdetailsButton;
            backButton = UIPersonifySetupWindow.UIBackWindow.UIBackButton;
        }
        #endregion          
    }
}
