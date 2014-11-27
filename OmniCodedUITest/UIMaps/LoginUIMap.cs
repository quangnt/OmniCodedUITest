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
    
    
    public partial class LoginUIMap
    {
        public Boolean Login(string sname, string spass)
        {
            this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIUsernameEdit.Text = sname;
            this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIPasswordEdit.Text = spass;
            Mouse.Click(this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UISignInButton);
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIWarning.GetProperty("IsOffscreen");
            return true;
        }
    }

}
