namespace OmniCodedUITest.UIMaps.LoginUIMapClasses
{
    using System;
    using System.Collections.Generic;
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
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    
    
    public partial class LoginUIMap
    {
        #region Login Controls
        public WpfButton xButton;
        public WpfButton googleSignInButton;
        public WpfEdit usernameEdit;
        public WpfEdit passwordEdit;
        public WpfButton signinButton;
        public WpfHyperlink forgotPasswordLink;
        public WpfButton signupButton;
        #endregion
        #region Constructor
        public LoginUIMap()
        {
            xButton = UIPersonifyMainLoginWindow.UICloseButton;
            googleSignInButton = UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIGoogleSignInButton;
            usernameEdit = UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIUsernameEdit;
            passwordEdit = UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIPasswordEdit;
            signinButton = UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UISignInButton;
            forgotPasswordLink = UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIForgotPassHyperlink;
            signupButton = UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UISignUpButton;
        }
        #endregion
    }
}
