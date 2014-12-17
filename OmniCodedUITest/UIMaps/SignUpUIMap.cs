namespace OmniCodedUITest.UIMaps.SignUpUIMapClasses
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
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    
    public partial class SignUpUIMap
    {
        #region SignUp Controls
        public WpfButton xButton;
        public WpfButton signUpGoogleButton;
        public HtmlEdit firstName;
        public HtmlEdit lastName;
        public HtmlEdit email;
        public HtmlEdit password;
        public HtmlEdit repeatPassword;
        public HtmlDiv warningMessage;
        public HtmlCheckBox agreeTerms;
        public HtmlHyperlink termsOfServices;
        public HtmlInputButton createAccountButton;
        public WpfButton signInButton;
        #endregion
        #region Constructor
        public SignUpUIMap()
        {
            xButton = UIPersonifyWindow.UICloseButton;
            signUpGoogleButton = UIPersonifyWindow.UIPersonifySignUpForm.UIGoogleSignUpButton;
            firstName = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UIFirstNameEdit;
            lastName = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UILastNameEdit;
            password = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UIUser_passwordEdit;
            repeatPassword = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UIRepeatEdit;
            warningMessage = UIPersonifySignUpSubForm.UIPersonifyOmniCreateaDocument.UIWarning;
            agreeTerms = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UIAgreeTermsCheckBox;
            termsOfServices = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UIIagreetotheTermsofSeLabel.UITermsofServiceHyperlink;
            createAccountButton = UIPersonifySignUpSubForm.UIPersonifyOmniCreateDocument.UICreateAccountButton;
            signInButton = UIPersonifyWindow.UIPersonifySignUpForm.UISignInButton;
        }
        #endregion
    }
}
